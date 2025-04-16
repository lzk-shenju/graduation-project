using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Linq;
using Emgu.CV.CvEnum;
using Emgu.CV.Util;
using System.Drawing;

namespace LearnOpenCVEdu.Utils
{
    public static class ImageProcessing
    {
        public static Mat SharpenImage(Mat sourceImage)
        {
            // 锐化卷积核（3x3）
            float[,] sharpenKernel = new float[,]
            {
            { 0, -1, 0 },
            { -1, 5, -1 },
            { 0, -1, 0 }
            };

            // 使用 Matrix<float> 构建核
            Matrix<float> kernelMatrix = new Matrix<float>(3, 3);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    kernelMatrix[i, j] = sharpenKernel[i, j];
                }
            }

            // 将 Matrix 转为 Mat
            Mat kernel = new Mat();
            kernelMatrix.Mat.CopyTo(kernel);

            // 应用卷积
            Mat resultImage = new Mat(sourceImage.Size, sourceImage.Depth, sourceImage.NumberOfChannels); //  明确尺寸和类型

            CvInvoke.Filter2D(
                sourceImage,
                resultImage,
                kernel,
                new Point(-1, -1) // 锚点为中心
            );

            return resultImage;
        }
    }
    public static class HistogramUtils
    {
        /// <summary>
        /// 执行直方图规定化（匹配）
        /// </summary>
        public static Mat MatchHistogram(Mat source, Mat template)
        {
            // 将Mat转换为Image<Gray, byte>以进行处理
            Image<Gray, byte> srcImg = source.ToImage<Gray, byte>();
            Image<Gray, byte> tplImg = template.ToImage<Gray, byte>();

            // 计算源图像和模板图像的直方图
            Mat histSrcMat = new Mat();
            Mat histTplMat = new Mat();

            // 设置直方图参数
            int[] histSize = { 256 };
            float[] ranges = { 0, 256 };
            int[] channels = { 0 };

            // 计算直方图
            CvInvoke.CalcHist(new VectorOfMat(srcImg.Mat), channels, null, histSrcMat, histSize, ranges, false);
            CvInvoke.CalcHist(new VectorOfMat(tplImg.Mat), channels, null, histTplMat, histSize, ranges, false);

            // 获取归一化的累积分布函数（CDF）
            float[] cdfSrc = GetCdf(histSrcMat);
            float[] cdfTpl = GetCdf(histTplMat);

            // 建立映射表
            byte[] lookup = new byte[256];
            for (int i = 0; i < 256; i++)
            {
                int j = 0;
                while (j < 255 && cdfSrc[i] > cdfTpl[j]) j++;
                lookup[i] = (byte)j;
            }

            // 应用映射
            Image<Gray, byte> resultImg = new Image<Gray, byte>(source.Size);
            for (int y = 0; y < srcImg.Height; y++)
            {
                for (int x = 0; x < srcImg.Width; x++)
                {
                    byte val = srcImg.Data[y, x, 0];
                    resultImg.Data[y, x, 0] = lookup[val];
                }
            }

            return resultImg.Mat;
        }

        /// <summary>
        /// 计算归一化的累计分布函数（CDF）
        /// </summary>
        //private static float[] GetCdf(Mat histMat)
        //{
        //    // 将 Mat 数据转换为 float 数组
        //    float[] histArray = new float[256];
        //    for (int i = 0; i < 256; i++)
        //    {
        //        histArray[i] = (float)histMat.GetData().GetValue(i);
        //    }

        //    // 计算 CDF
        //    float sum = histArray.Sum();
        //    float[] cdf = new float[256];
        //    float cumulative = 0;
        //    for (int i = 0; i < 256; i++)
        //    {
        //        cumulative += histArray[i];
        //        cdf[i] = cumulative / sum;
        //    }

        //    return cdf;
        //}
        private static float[] GetCdf(Mat histMat)
        {
            // 将 Mat 数据转换为 float 数组
            float[] histArray = new float[256];

            // 转换成浮点数类型
            Mat floatMat = new Mat();
            if (histMat.Depth != DepthType.Cv32F)
            {
                histMat.ConvertTo(floatMat, DepthType.Cv32F);
            }
            else
            {
                floatMat = histMat.Clone();
            }

            // 直接使用指针访问数据
            unsafe
            {
                float* dataPtr = (float*)floatMat.DataPointer.ToPointer();
                for (int i = 0; i < Math.Min(256, floatMat.Total.ToInt32()); i++)
                {
                    histArray[i] = dataPtr[i];
                }
            }

            // 计算 CDF
            float sum = histArray.Sum();
            // 避免除零错误
            sum = sum > 0 ? sum : 1f;

            float[] cdf = new float[256];
            float cumulative = 0;
            for (int i = 0; i < 256; i++)
            {
                cumulative += histArray[i];
                cdf[i] = cumulative / sum;
            }

            return cdf;
        }
       
        }
    
   
}