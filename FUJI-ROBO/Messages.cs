using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace FUJI_ROBO
{
    public class Messages : ModuleBase
    {
        [Command("help")]
        public async Task help()
        {
            string Messages = 
@"[|(ﾟ)(ﾟ)|]　fuji-roboの機能ヘルプ　[|(ﾟ)(ﾟ)|]\n
now: 現在時刻を表示\n
sumabura: 大乱闘を開幕する";

            await ReplyAsync(Messages);
        }

        [Command("now")]
        public async Task now()
        {
            string Messages = "[|⌒⌒|]　ロボットが " + DateTime.Now.ToString(@"H時m分s秒") + " をお知らせするぞ　[|⌒⌒|]\n";

            await ReplyAsync(Messages);
        }

        [Command("sumabura")]
        public async Task sumabura()
        {
            await ReplyAsync(sumaAA);
        }

        string sumaAA = @"　　　
　　　スマブラの遊び方を教えてやる････
　文句のあるやつ全員まとめてかかって来い････

　　　　　　　　大　　　乱　　　闘

　　　　　　開　　　　　幕　　　　　だ
　 　　  ｎ:　　　　　　 ＿＿＿　　　　 　ｎ:
　　　　 |｜　　　　／　＿＿　＼　　　 .|｜
　　　　 |｜　　　　|　|(ﾟ)　　(ﾟ)|　|　　 　|｜
　　　　ｆ｢| |^ﾄ　　 　ヽ ￣￣￣ /　　　｢| |^|`|
　　　 |: ::　 ! }　　　　 ￣□￣ 　　　 | !　 : ::}
　　　 ヽ　　,ｲ　 ／￣￣ハ￣￣＼　 ヽ　　,ｲ";

    }
}
