using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ted.RandomInfoGenerator
{
    public class TWNamesGenerator : IRandomInfoGenerator<string>
    {
        private string[] _surnames;
        private string _names;
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Info => LastName+ FirstName;
        private int _nullableProbability;
        public readonly Random _random = new Random(Guid.NewGuid().GetHashCode());
        private bool IsNull => _nullableProbability > _random.Next(0, 101);
        private bool _gender;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="gender">性別</param>
        /// <param name="nullableProbability">可能為空值的機率</param>
        public TWNamesGenerator(bool gender, int nullableProbability = 0)
        {
            #region 初始化名字
            _surnames = new string[] { "陳", "林", "黃", "張", "李", "王", "吳", "劉", "蔡", "楊", "許", "鄭", "謝", "郭", "洪", "曾", "邱", "廖", "賴", "徐", "周", "葉", "蘇", "莊", "呂", "江", "何", "顏", "劉", "詹", "胡", "蕭", "董", "孫", "陸", "金", "石", "唐", "方", "宋", "鄧", "杜", "傅", "侯", "曹", "薛", "邵", "孟", "熊", "秦", "白", "江", "閻", "董", "潘", "蔣", "歐陽", "許", "蕭", "邱", "韓", "任", "姚", "湯", "方", "簡", "魏", "馮","范姜","殷","粘","錢","柯","張簡","應"};
            if (gender)
            {
                _names = "偉宏文弘正志明展瑞信政豪智元昌建榮銘嘉成祥振彥龍友邦志成信茂昭翰全家興岳福德洪正慶泰義明瑋仁亞俊浩國哲睿生達琦維宜盛浩銓泓逸佑凱傑昆誠彬毅鴻耀曉育宇修凡庭喬群竣語晨岑宗陽煌欣豪群霖聰韋柏軒曜陽煒建志達書駿竹義詠翔祐淳樺憲宥澤揚健昱哲正宏榮恩融宣慈康軒裕綸芳彥祐民宸鈞彥晟彬玟凱宣皓靖宸翰宣彰瀚鴻軒駿語翔銘群亦柏鑫彥仁仕承祖浚宇沛安勝泰齊樂凡榮泰謙毅德宗政興富春建慶";
            }
            else
            {
                _names = "靜淑雯雅婷惠君佩琪筱薇嘉慧雨文芳伊琳瑞萍蓮美晴娟怡玉秀珍瑜宛玫儀鳳蘭瓊蓉菁璇茹潔筑梅妮欣麗雅瑛茜淑如蓁麗華鳳瑩悅靖瑤妤琬翠嬌霞青綺淳瑄儀藍凌怡莉盈依葳津蕊涵雪芬穎芳雅若萱云鈺霖思玲甄韻麟芸敏媛臻維芮帆芸敏彤慧芃冠妙銘媚琬穗絜妍茗喬珊枝琛彥娥蔚玟茜儷蔓珮婷瑾惟雯璿沛羽梨燕勻伶涵珈妍穎岑伊慧柔韻宜嬿燕雯麗菁吟君函雁純";
            }
            #endregion
            _gender = gender;
            _nullableProbability = nullableProbability;
            NextInfo();

		}
        public string NextInfo()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            if (IsNull) return string.Empty;
            GetFirstName();
            GetLastName();
            return Info;

		}
        private void GetFirstName()
        {
            FirstName += _names[_random.Next(0, _names.Length)].ToString();
            if (5 >= _random.Next(0, 101)) return;
            if (!_gender && 5 >= _random.Next(0, 101)) 
            {
                FirstName += FirstName;
                return;
            }
            FirstName += _names[_random.Next(0, _names.Length)].ToString();
        }
        private void GetLastName()
        {
            LastName = _surnames[_random.Next(0, _surnames.Length)];
        }

    }
}
