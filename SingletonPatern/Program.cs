using System;

namespace SingletonPatern
{
    public class Sample
    {

        //Durum bilgisi(State)
        private int m_data;
        private static Sample m_tmp = null;

        public int Data { get { return m_data; } }
        private Sample(int prm)
        {
            Console.WriteLine("Sample const çağrıldı");
            m_data = prm;
        }

        public static Sample CreateSample(int data)
        {
            if (m_tmp == null)
            {
                m_tmp = new Sample(prm: data);
            }

            return m_tmp;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample sample =  Sample.CreateSample(1);
            Sample sample2 = Sample.CreateSample(2);

            Console.WriteLine("sample1:"+sample.Data);
            Console.WriteLine("sample2:"+sample2.Data);
        }
    }
}
