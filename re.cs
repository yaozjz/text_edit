using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace text_edit
{
    class re
    {
        /// <summary>
        /// 返回匹配结果内容
        /// </summary>
        /// <param name="input">输入文本</param>
        /// <param name="rule">正则表达式</param>
        /// <returns></returns>
        public static string Match(string input,string rule)
        {
            return Regex.Match(input, rule).Value;
        }

        //
    }
}
