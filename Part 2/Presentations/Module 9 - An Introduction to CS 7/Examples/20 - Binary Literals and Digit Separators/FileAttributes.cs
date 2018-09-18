namespace Wincubate.CS7.Slide20
{
    public enum FileAttributes
    {
        ReadOnly =          0b00_00_00_00_00_00_01, // 0x0001
        Hidden =            0b00_00_00_00_00_00_10, // 0x0002
        System =            0b00_00_00_00_00_01_00, // 0x0004
        Directory =         0b00_00_00_00_00_10_00, // 0x0008
        Archive =           0b00_00_00_00_01_00_00, // 0x0010
        Device =            0b00_00_00_00_10_00_00, // 0x0020   
        Normal =            0b00_00_00_01_00_00_00, // 0x0040
        Temporary =         0b00_00_00_10_00_00_00, // 0x0080   
        SparseFile =        0b00_00_01_00_00_00_00, // 0x0100   
        ReparsePoint =      0b00_00_10_00_00_00_00, // 0x0200   
        Compressed =        0b00_01_00_00_00_00_00, // 0x0400
        Offline =           0b00_10_00_00_00_00_00, // 0x0800   
        NotContentIndexed = 0b01_00_00_00_00_00_00, // 0x1000
        Encrypted =         0b10_00_00_00_00_00_00  // 0x2000
    }
}
