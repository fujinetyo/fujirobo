using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace Fujirobo
{
    public class Messages : ModuleBase
    {
        [Command("help")]
        public async Task help()
        {
            string Messages = "[|(ﾟ)(ﾟ)|]　fuji-roboの機能ヘルプ　[|(ﾟ)(ﾟ)|]\nnow: 現在時刻を表示\n";

            await ReplyAsync(Messages);
        }

        [Command("now")]
        public async Task now()
        {
            string Messages = "ロボットが " + DateTime.Now.ToString(@"H時m分s秒") + " をお知らせするぞ　[|⌒⌒|]\n";

            await ReplyAsync(Messages);
        }

        [Command("sumabura")]
        public async Task sumabura()
        {
            await ReplyAsync(sumabura);
        }

        var sumabura = @"
　　　　　　　　　　　　　スマブラの遊び方を教えてやる････\n
　　　　　　　　　　　文句のあるやつ全員まとめてかかって来い････\n
\n
　　　　　　　　　　　　　　　　　　大　　　乱　　　闘\n
\n
　　　　　　　　　　　　　　　　開　　　　　幕　　　　　だ\n
　　　　　　　　 　　　　　 ｎ:　　　　　　 ＿＿＿　　　　 　ｎ:\n
　　　　　　　　　 　 　　　|｜　　　　／　＿＿　＼　　　 .|｜\n
　　　　　　　　　 　 　　　|｜　　　　|　|(ﾟ)　　(ﾟ)|　|　　 　|｜\n
　　　　　　　　　 　 　　ｆ｢| |^ﾄ　　 　ヽ ￣￣￣ /　　　｢| |^|`|\n
　　　　　　　　　 　 　　|: ::　 ! }　　　　 ￣□￣ 　　　 | !　 : ::}\n
　　　　　　　　　 　　　 ヽ　　,ｲ　 ／￣￣ハ￣￣＼　 ヽ　　,ｲ\n";

    }
}
