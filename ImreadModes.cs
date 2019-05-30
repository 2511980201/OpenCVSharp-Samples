enum ImreadModes
{
    IMREAD_UNCHANGED = -1, //如果设置，则返回的数据带有alpha通道（R,G,B,A 四个通道），否则没有alpha通道
    IMREAD_GRAYSCALE = 0,  //如果设置，则将图像转换为单通道灰度图像
    IMREAD_COLOR = 1,  //如果设置，则将图像转换成3通道BGR彩色图像
    IMREAD_ANYDEPTH = 2,  //如果设置，则在输入具有相应深度时返回16位/32位图像，否则将其转换为8位
    IMREAD_ANYCOLOR = 4,  //如果设置，则图像可能以任何颜色格式读取
    IMREAD_LOAD_GDAL = 8,  //如果设置，使用gdal驱动程序加载图像
    IMREAD_REDUCED_GRAYSCALE_2 = 16, //如果设置，总是将图像转换为单通道灰度图像且图像大小减少1/2
    IMREAD_REDUCED_COLOR_2 = 17, //如果设置，总是将图像转换为3通道BGR彩色图像且图像大小减少1/2
    IMREAD_REDUCED_GRAYSCALE_4 = 32, //如果设置，总是将图像转换为单通道灰度图像且图像大小减少1/4
    IMREAD_REDUCED_COLOR_4 = 33, //如果设置，总是将图像转换为3通道BGR彩色图像且图像大小减少1/4
    IMREAD_REDUCED_GRAYSCALE_8 = 64, //如果设置，总是将图像转换为单通道灰度图像且图像大小减少1/8
    IMREAD_REDUCED_COLOR_8 = 65, //如果设置，总是将图像转换为3通道BGR彩色图像且图像大小减少1/4
    IMREAD_IGNORE_ORIENTATION = 128 //如果设置，不会根据EXIF的方向标志旋转图像
};