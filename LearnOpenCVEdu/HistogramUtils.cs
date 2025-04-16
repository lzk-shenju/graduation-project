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
            // �񻯾���ˣ�3x3��
            float[,] sharpenKernel = new float[,]
            {
            { 0, -1, 0 },
            { -1, 5, -1 },
            { 0, -1, 0 }
            };

            // ʹ�� Matrix<float> ������
            Matrix<float> kernelMatrix = new Matrix<float>(3, 3);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    kernelMatrix[i, j] = sharpenKernel[i, j];
                }
            }

            // �� Matrix תΪ Mat
            Mat kernel = new Mat();
            kernelMatrix.Mat.CopyTo(kernel);

            // Ӧ�þ��
            Mat resultImage = new Mat(sourceImage.Size, sourceImage.Depth, sourceImage.NumberOfChannels); //  ��ȷ�ߴ������

            CvInvoke.Filter2D(
                sourceImage,
                resultImage,
                kernel,
                new Point(-1, -1) // ê��Ϊ����
            );

            return resultImage;
        }
    }
    public static class HistogramUtils
    {
        /// <summary>
        /// ִ��ֱ��ͼ�涨����ƥ�䣩
        /// </summary>
        public static Mat MatchHistogram(Mat source, Mat template)
        {
            // ��Matת��ΪImage<Gray, byte>�Խ��д���
            Image<Gray, byte> srcImg = source.ToImage<Gray, byte>();
            Image<Gray, byte> tplImg = template.ToImage<Gray, byte>();

            // ����Դͼ���ģ��ͼ���ֱ��ͼ
            Mat histSrcMat = new Mat();
            Mat histTplMat = new Mat();

            // ����ֱ��ͼ����
            int[] histSize = { 256 };
            float[] ranges = { 0, 256 };
            int[] channels = { 0 };

            // ����ֱ��ͼ
            CvInvoke.CalcHist(new VectorOfMat(srcImg.Mat), channels, null, histSrcMat, histSize, ranges, false);
            CvInvoke.CalcHist(new VectorOfMat(tplImg.Mat), channels, null, histTplMat, histSize, ranges, false);

            // ��ȡ��һ�����ۻ��ֲ�������CDF��
            float[] cdfSrc = GetCdf(histSrcMat);
            float[] cdfTpl = GetCdf(histTplMat);

            // ����ӳ���
            byte[] lookup = new byte[256];
            for (int i = 0; i < 256; i++)
            {
                int j = 0;
                while (j < 255 && cdfSrc[i] > cdfTpl[j]) j++;
                lookup[i] = (byte)j;
            }

            // Ӧ��ӳ��
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
        /// �����һ�����ۼƷֲ�������CDF��
        /// </summary>
        //private static float[] GetCdf(Mat histMat)
        //{
        //    // �� Mat ����ת��Ϊ float ����
        //    float[] histArray = new float[256];
        //    for (int i = 0; i < 256; i++)
        //    {
        //        histArray[i] = (float)histMat.GetData().GetValue(i);
        //    }

        //    // ���� CDF
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
            // �� Mat ����ת��Ϊ float ����
            float[] histArray = new float[256];

            // ת���ɸ���������
            Mat floatMat = new Mat();
            if (histMat.Depth != DepthType.Cv32F)
            {
                histMat.ConvertTo(floatMat, DepthType.Cv32F);
            }
            else
            {
                floatMat = histMat.Clone();
            }

            // ֱ��ʹ��ָ���������
            unsafe
            {
                float* dataPtr = (float*)floatMat.DataPointer.ToPointer();
                for (int i = 0; i < Math.Min(256, floatMat.Total.ToInt32()); i++)
                {
                    histArray[i] = dataPtr[i];
                }
            }

            // ���� CDF
            float sum = histArray.Sum();
            // ����������
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