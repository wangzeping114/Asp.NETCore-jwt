namespace HYPJ.Utilities.Helper
{
    public class HtmlUIHelper
    {
        /// <summary>
        /// 高亮关键字
        /// </summary>
        /// <param name="str">内容</param>
        /// <param name="key">高亮关键字</param>
        /// <returns></returns>
        public static string Highlight(string str, string key)
        {
            if (string.IsNullOrEmpty(str)) { return str; }
            if (string.IsNullOrWhiteSpace(str)) { return str; }
            if (key.Length == 0) { return str; }
            return str.Replace(key, string.Format("<font color='red'>{0}</font>", key));
        }
    }
}
