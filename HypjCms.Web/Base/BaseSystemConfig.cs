namespace HypjCms.Web.Base
{
    public struct BaseSystemConfig
    {
        public static int SystemID => 100101;                    //系统编号
        public static int AccessTokenExpiresIn => 7200;          //token过期时间：  7200秒    2小时
        public static int RefreshTokenExpiresIn => 2592000;      //refresh过期时间：2592000秒 30天
        public static string SessionUser => ".HypjCmsNetCore";     //Session名称
          
    }
}
