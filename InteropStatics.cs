using System;
using System.Runtime.InteropServices;

namespace SDKTemplate
{
    public static class InteropStatics
    {
        [DllImport(
            "C:\\Users\\katie\\Documents\\IIB\\Project\\RealTimeSim\\Debug\\RealTimeSim.dll",
            EntryPoint = "sumTwo",
            SetLastError = true,
            CharSet = CharSet.Unicode,
            ExactSpelling = true,
            CallingConvention = CallingConvention.StdCall
            )]
        public static extern double sumTwo(double var_x, double var_y);

    }
}
