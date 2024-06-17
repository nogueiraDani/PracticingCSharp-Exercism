using System;

public static class TelemetryBuffer

{
    public static byte[] ToBuffer(long reading)
    {
        var sign = Sign(reading);
        var bytes = sign switch
        {
            248 => BitConverter.GetBytes(reading),
            252 => BitConverter.GetBytes((int)reading),
            254 => BitConverter.GetBytes((short)reading),
            2 => BitConverter.GetBytes((ushort)reading),
            4 => BitConverter.GetBytes((uint)reading),
            _ => throw new ArgumentOutOfRangeException()

        };

        var result = new byte[9];
        result[0] = sign;

        bytes.CopyTo(result, 1);

        return result;

    }


    public static long FromBuffer(byte[] buffer)
    {
        return buffer[0] switch
        {
            248 => BitConverter.ToInt64(buffer[1..]),
            252 => BitConverter.ToInt32(buffer[1..5]),
            254 => BitConverter.ToInt16(buffer[1..3]),
            2 => BitConverter.ToUInt16(buffer[1..3]),
            4 => BitConverter.ToUInt32(buffer[1..5]),
            _ => 0
        };
    }


    private static byte Sign(long reading)
    {
        return reading switch
        {
            >= 4_294_967_296 and <= 9_223_372_036_854_775_807 or >= -9_223_372_036_854_775_808 and <= -2_147_483_649 => 248,

            >= 65_536 and <= 2_147_483_647 or >= -2_147_483_648 and <= -32_769 => 252,

            >= -32_768 and <= -1 => 254,

            >= 0 and <= 65_535 => 2,

            >= 2_147_483_648 and <= 4_294_967_295 => 4

        };
    }
}