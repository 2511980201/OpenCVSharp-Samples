enum ImreadModes
{
    IMREAD_UNCHANGED = -1, //������ã��򷵻ص����ݴ���alphaͨ����R,G,B,A �ĸ�ͨ����������û��alphaͨ��
    IMREAD_GRAYSCALE = 0,  //������ã���ͼ��ת��Ϊ��ͨ���Ҷ�ͼ��
    IMREAD_COLOR = 1,  //������ã���ͼ��ת����3ͨ��BGR��ɫͼ��
    IMREAD_ANYDEPTH = 2,  //������ã��������������Ӧ���ʱ����16λ/32λͼ�񣬷�����ת��Ϊ8λ
    IMREAD_ANYCOLOR = 4,  //������ã���ͼ��������κ���ɫ��ʽ��ȡ
    IMREAD_LOAD_GDAL = 8,  //������ã�ʹ��gdal�����������ͼ��
    IMREAD_REDUCED_GRAYSCALE_2 = 16, //������ã����ǽ�ͼ��ת��Ϊ��ͨ���Ҷ�ͼ����ͼ���С����1/2
    IMREAD_REDUCED_COLOR_2 = 17, //������ã����ǽ�ͼ��ת��Ϊ3ͨ��BGR��ɫͼ����ͼ���С����1/2
    IMREAD_REDUCED_GRAYSCALE_4 = 32, //������ã����ǽ�ͼ��ת��Ϊ��ͨ���Ҷ�ͼ����ͼ���С����1/4
    IMREAD_REDUCED_COLOR_4 = 33, //������ã����ǽ�ͼ��ת��Ϊ3ͨ��BGR��ɫͼ����ͼ���С����1/4
    IMREAD_REDUCED_GRAYSCALE_8 = 64, //������ã����ǽ�ͼ��ת��Ϊ��ͨ���Ҷ�ͼ����ͼ���С����1/8
    IMREAD_REDUCED_COLOR_8 = 65, //������ã����ǽ�ͼ��ת��Ϊ3ͨ��BGR��ɫͼ����ͼ���С����1/4
    IMREAD_IGNORE_ORIENTATION = 128 //������ã��������EXIF�ķ����־��תͼ��
};