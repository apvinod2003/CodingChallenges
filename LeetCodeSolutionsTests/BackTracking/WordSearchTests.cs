﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.BackTracking.Tests
{
    [TestClass()]
    public class WordSearchTests
    {
        WordSearch search;
        // This method runs before each MSTest test method
        [TestInitialize]
        public void Setup()
        {
            search = new WordSearch();
        }

        // This method runs after each MSTest test method
        [TestCleanup]
        public void Teardown()
        {
            search = null;
        }


        [TestMethod()]
        public void FindWordsTest()
        {
            char[][] input = {
            new char[] { 'o', 'a', 'a', 'n' },
            new char[] { 'e', 't', 'a', 'e' },
            new char[] { 'i', 'h', 'k', 'r' },
            new char[] { 'i', 'f', 'l', 'v' }
            };

            string[] words = ["oath", "pea", "eat", "rain"];



            var result = search.FindWords(input, words);

            Assert.IsTrue(result.Contains("eat") && result.Contains("oath"));


        }

        [TestMethod()]
        public void FindWordsTest1()
        {

            char[][] input = {
            new char[] { 'm', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l' },
            new char[] { 'n', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a' },
            new char[] { 'o', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a' },
            new char[] { 'p', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a' },
            new char[] { 'q', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a' },
            new char[] { 'r', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a' },
            new char[] { 's', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a' },
            new char[] { 't', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a' },
            new char[] { 'u', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a' },
            new char[] { 'v', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a' },
            new char[] { 'w', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a' },
            new char[] { 'x', 'y', 'z', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a' }
            };

            string[] words = ["aaaaaaaaaa", "aaaaaaaaab", "aaaaaaaaac", "aaaaaaaaad", "aaaaaaaaae", "aaaaaaaaaf", "aaaaaaaaag", "aaaaaaaaah", "aaaaaaaaai", "aaaaaaaaaj", "aaaaaaaaak", "aaaaaaaaal", "aaaaaaaaam", "aaaaaaaaan", "aaaaaaaaao", "aaaaaaaaap", "aaaaaaaaaq", "aaaaaaaaar", "aaaaaaaaas", "aaaaaaaaat", "aaaaaaaaau", "aaaaaaaaav", "aaaaaaaaaw", "aaaaaaaaax", "aaaaaaaaay", "aaaaaaaaaz", "aaaaaaaaba", "aaaaaaaabb", "aaaaaaaabc", "aaaaaaaabd", "aaaaaaaabe", "aaaaaaaabf", "aaaaaaaabg", "aaaaaaaabh", "aaaaaaaabi", "aaaaaaaabj", "aaaaaaaabk", "aaaaaaaabl", "aaaaaaaabm", "aaaaaaaabn", "aaaaaaaabo", "aaaaaaaabp", "aaaaaaaabq", "aaaaaaaabr", "aaaaaaaabs", "aaaaaaaabt", "aaaaaaaabu", "aaaaaaaabv", "aaaaaaaabw", "aaaaaaaabx", "aaaaaaaaby", "aaaaaaaabz", "aaaaaaaaca", "aaaaaaaacb", "aaaaaaaacc", "aaaaaaaacd", "aaaaaaaace", "aaaaaaaacf", "aaaaaaaacg", "aaaaaaaach", "aaaaaaaaci", "aaaaaaaacj", "aaaaaaaack", "aaaaaaaacl", "aaaaaaaacm", "aaaaaaaacn", "aaaaaaaaco", "aaaaaaaacp", "aaaaaaaacq", "aaaaaaaacr", "aaaaaaaacs", "aaaaaaaact", "aaaaaaaacu", "aaaaaaaacv", "aaaaaaaacw", "aaaaaaaacx", "aaaaaaaacy", "aaaaaaaacz", "aaaaaaaada", "aaaaaaaadb", "aaaaaaaadc", "aaaaaaaadd", "aaaaaaaade", "aaaaaaaadf", "aaaaaaaadg", "aaaaaaaadh", "aaaaaaaadi", "aaaaaaaadj", "aaaaaaaadk", "aaaaaaaadl", "aaaaaaaadm", "aaaaaaaadn", "aaaaaaaado", "aaaaaaaadp", "aaaaaaaadq", "aaaaaaaadr", "aaaaaaaads", "aaaaaaaadt", "aaaaaaaadu", "aaaaaaaadv", "aaaaaaaadw", "aaaaaaaadx", "aaaaaaaady", "aaaaaaaadz", "aaaaaaaaea", "aaaaaaaaeb", "aaaaaaaaec", "aaaaaaaaed", "aaaaaaaaee", "aaaaaaaaef", "aaaaaaaaeg", "aaaaaaaaeh", "aaaaaaaaei", "aaaaaaaaej", "aaaaaaaaek", "aaaaaaaael", "aaaaaaaaem", "aaaaaaaaen", "aaaaaaaaeo", "aaaaaaaaep", "aaaaaaaaeq", "aaaaaaaaer", "aaaaaaaaes", "aaaaaaaaet", "aaaaaaaaeu", "aaaaaaaaev", "aaaaaaaaew", "aaaaaaaaex", "aaaaaaaaey", "aaaaaaaaez", "aaaaaaaafa", "aaaaaaaafb", "aaaaaaaafc", "aaaaaaaafd", "aaaaaaaafe", "aaaaaaaaff", "aaaaaaaafg", "aaaaaaaafh", "aaaaaaaafi", "aaaaaaaafj", "aaaaaaaafk", "aaaaaaaafl", "aaaaaaaafm", "aaaaaaaafn", "aaaaaaaafo", "aaaaaaaafp", "aaaaaaaafq", "aaaaaaaafr", "aaaaaaaafs", "aaaaaaaaft", "aaaaaaaafu", "aaaaaaaafv", "aaaaaaaafw", "aaaaaaaafx", "aaaaaaaafy", "aaaaaaaafz", "aaaaaaaaga", "aaaaaaaagb", "aaaaaaaagc", "aaaaaaaagd", "aaaaaaaage", "aaaaaaaagf", "aaaaaaaagg", "aaaaaaaagh", "aaaaaaaagi", "aaaaaaaagj", "aaaaaaaagk", "aaaaaaaagl", "aaaaaaaagm", "aaaaaaaagn", "aaaaaaaago", "aaaaaaaagp", "aaaaaaaagq", "aaaaaaaagr", "aaaaaaaags", "aaaaaaaagt", "aaaaaaaagu", "aaaaaaaagv", "aaaaaaaagw", "aaaaaaaagx", "aaaaaaaagy", "aaaaaaaagz", "aaaaaaaaha", "aaaaaaaahb", "aaaaaaaahc", "aaaaaaaahd", "aaaaaaaahe", "aaaaaaaahf", "aaaaaaaahg", "aaaaaaaahh", "aaaaaaaahi", "aaaaaaaahj", "aaaaaaaahk", "aaaaaaaahl", "aaaaaaaahm", "aaaaaaaahn", "aaaaaaaaho", "aaaaaaaahp", "aaaaaaaahq", "aaaaaaaahr", "aaaaaaaahs", "aaaaaaaaht", "aaaaaaaahu", "aaaaaaaahv", "aaaaaaaahw", "aaaaaaaahx", "aaaaaaaahy", "aaaaaaaahz", "aaaaaaaaia", "aaaaaaaaib", "aaaaaaaaic", "aaaaaaaaid", "aaaaaaaaie", "aaaaaaaaif", "aaaaaaaaig", "aaaaaaaaih", "aaaaaaaaii", "aaaaaaaaij", "aaaaaaaaik", "aaaaaaaail", "aaaaaaaaim", "aaaaaaaain", "aaaaaaaaio", "aaaaaaaaip", "aaaaaaaaiq", "aaaaaaaair", "aaaaaaaais", "aaaaaaaait", "aaaaaaaaiu", "aaaaaaaaiv", "aaaaaaaaiw", "aaaaaaaaix", "aaaaaaaaiy", "aaaaaaaaiz", "aaaaaaaaja", "aaaaaaaajb", "aaaaaaaajc", "aaaaaaaajd", "aaaaaaaaje", "aaaaaaaajf", "aaaaaaaajg", "aaaaaaaajh", "aaaaaaaaji", "aaaaaaaajj", "aaaaaaaajk", "aaaaaaaajl", "aaaaaaaajm", "aaaaaaaajn", "aaaaaaaajo", "aaaaaaaajp", "aaaaaaaajq", "aaaaaaaajr", "aaaaaaaajs", "aaaaaaaajt", "aaaaaaaaju", "aaaaaaaajv", "aaaaaaaajw", "aaaaaaaajx", "aaaaaaaajy", "aaaaaaaajz", "aaaaaaaaka", "aaaaaaaakb", "aaaaaaaakc", "aaaaaaaakd", "aaaaaaaake", "aaaaaaaakf", "aaaaaaaakg", "aaaaaaaakh", "aaaaaaaaki", "aaaaaaaakj", "aaaaaaaakk", "aaaaaaaakl", "aaaaaaaakm", "aaaaaaaakn", "aaaaaaaako", "aaaaaaaakp", "aaaaaaaakq", "aaaaaaaakr", "aaaaaaaaks", "aaaaaaaakt", "aaaaaaaaku", "aaaaaaaakv", "aaaaaaaakw", "aaaaaaaakx", "aaaaaaaaky", "aaaaaaaakz", "aaaaaaaala", "aaaaaaaalb", "aaaaaaaalc", "aaaaaaaald", "aaaaaaaale", "aaaaaaaalf", "aaaaaaaalg", "aaaaaaaalh", "aaaaaaaali", "aaaaaaaalj", "aaaaaaaalk", "aaaaaaaall", "aaaaaaaalm", "aaaaaaaaln", "aaaaaaaalo", "aaaaaaaalp", "aaaaaaaalq", "aaaaaaaalr", "aaaaaaaals", "aaaaaaaalt", "aaaaaaaalu", "aaaaaaaalv", "aaaaaaaalw", "aaaaaaaalx", "aaaaaaaaly", "aaaaaaaalz", "aaaaaaaama", "aaaaaaaamb", "aaaaaaaamc", "aaaaaaaamd", "aaaaaaaame", "aaaaaaaamf", "aaaaaaaamg", "aaaaaaaamh", "aaaaaaaami", "aaaaaaaamj", "aaaaaaaamk", "aaaaaaaaml", "aaaaaaaamm", "aaaaaaaamn", "aaaaaaaamo", "aaaaaaaamp", "aaaaaaaamq", "aaaaaaaamr", "aaaaaaaams", "aaaaaaaamt", "aaaaaaaamu", "aaaaaaaamv", "aaaaaaaamw", "aaaaaaaamx", "aaaaaaaamy", "aaaaaaaamz", "aaaaaaaana", "aaaaaaaanb", "aaaaaaaanc", "aaaaaaaand", "aaaaaaaane", "aaaaaaaanf", "aaaaaaaang", "aaaaaaaanh", "aaaaaaaani", "aaaaaaaanj", "aaaaaaaank", "aaaaaaaanl", "aaaaaaaanm", "aaaaaaaann", "aaaaaaaano", "aaaaaaaanp", "aaaaaaaanq", "aaaaaaaanr", "aaaaaaaans", "aaaaaaaant", "aaaaaaaanu", "aaaaaaaanv", "aaaaaaaanw", "aaaaaaaanx", "aaaaaaaany", "aaaaaaaanz", "aaaaaaaaoa", "aaaaaaaaob", "aaaaaaaaoc", "aaaaaaaaod", "aaaaaaaaoe", "aaaaaaaaof", "aaaaaaaaog", "aaaaaaaaoh", "aaaaaaaaoi", "aaaaaaaaoj", "aaaaaaaaok", "aaaaaaaaol", "aaaaaaaaom", "aaaaaaaaon", "aaaaaaaaoo", "aaaaaaaaop", "aaaaaaaaoq", "aaaaaaaaor", "aaaaaaaaos", "aaaaaaaaot", "aaaaaaaaou", "aaaaaaaaov", "aaaaaaaaow", "aaaaaaaaox", "aaaaaaaaoy", "aaaaaaaaoz", "aaaaaaaapa", "aaaaaaaapb", "aaaaaaaapc", "aaaaaaaapd", "aaaaaaaape", "aaaaaaaapf", "aaaaaaaapg", "aaaaaaaaph", "aaaaaaaapi", "aaaaaaaapj", "aaaaaaaapk", "aaaaaaaapl", "aaaaaaaapm", "aaaaaaaapn", "aaaaaaaapo", "aaaaaaaapp", "aaaaaaaapq", "aaaaaaaapr", "aaaaaaaaps", "aaaaaaaapt", "aaaaaaaapu", "aaaaaaaapv", "aaaaaaaapw", "aaaaaaaapx", "aaaaaaaapy", "aaaaaaaapz", "aaaaaaaaqa", "aaaaaaaaqb", "aaaaaaaaqc", "aaaaaaaaqd", "aaaaaaaaqe", "aaaaaaaaqf", "aaaaaaaaqg", "aaaaaaaaqh", "aaaaaaaaqi", "aaaaaaaaqj", "aaaaaaaaqk", "aaaaaaaaql", "aaaaaaaaqm", "aaaaaaaaqn", "aaaaaaaaqo", "aaaaaaaaqp", "aaaaaaaaqq", "aaaaaaaaqr", "aaaaaaaaqs", "aaaaaaaaqt", "aaaaaaaaqu", "aaaaaaaaqv", "aaaaaaaaqw", "aaaaaaaaqx", "aaaaaaaaqy", "aaaaaaaaqz", "aaaaaaaara", "aaaaaaaarb", "aaaaaaaarc", "aaaaaaaard", "aaaaaaaare", "aaaaaaaarf", "aaaaaaaarg", "aaaaaaaarh", "aaaaaaaari", "aaaaaaaarj", "aaaaaaaark", "aaaaaaaarl", "aaaaaaaarm", "aaaaaaaarn", "aaaaaaaaro", "aaaaaaaarp", "aaaaaaaarq", "aaaaaaaarr", "aaaaaaaars", "aaaaaaaart", "aaaaaaaaru", "aaaaaaaarv", "aaaaaaaarw", "aaaaaaaarx", "aaaaaaaary", "aaaaaaaarz", "aaaaaaaasa", "aaaaaaaasb", "aaaaaaaasc", "aaaaaaaasd", "aaaaaaaase", "aaaaaaaasf", "aaaaaaaasg", "aaaaaaaash", "aaaaaaaasi", "aaaaaaaasj", "aaaaaaaask", "aaaaaaaasl", "aaaaaaaasm", "aaaaaaaasn", "aaaaaaaaso", "aaaaaaaasp", "aaaaaaaasq", "aaaaaaaasr", "aaaaaaaass", "aaaaaaaast", "aaaaaaaasu", "aaaaaaaasv", "aaaaaaaasw", "aaaaaaaasx", "aaaaaaaasy", "aaaaaaaasz", "aaaaaaaata", "aaaaaaaatb", "aaaaaaaatc", "aaaaaaaatd", "aaaaaaaate", "aaaaaaaatf", "aaaaaaaatg", "aaaaaaaath", "aaaaaaaati", "aaaaaaaatj", "aaaaaaaatk", "aaaaaaaatl", "aaaaaaaatm", "aaaaaaaatn", "aaaaaaaato", "aaaaaaaatp", "aaaaaaaatq", "aaaaaaaatr", "aaaaaaaats", "aaaaaaaatt", "aaaaaaaatu", "aaaaaaaatv", "aaaaaaaatw", "aaaaaaaatx", "aaaaaaaaty", "aaaaaaaatz", "aaaaaaaaua", "aaaaaaaaub", "aaaaaaaauc", "aaaaaaaaud", "aaaaaaaaue", "aaaaaaaauf", "aaaaaaaaug", "aaaaaaaauh", "aaaaaaaaui", "aaaaaaaauj", "aaaaaaaauk", "aaaaaaaaul", "aaaaaaaaum", "aaaaaaaaun", "aaaaaaaauo", "aaaaaaaaup", "aaaaaaaauq", "aaaaaaaaur", "aaaaaaaaus", "aaaaaaaaut", "aaaaaaaauu", "aaaaaaaauv", "aaaaaaaauw", "aaaaaaaaux", "aaaaaaaauy", "aaaaaaaauz", "aaaaaaaava", "aaaaaaaavb", "aaaaaaaavc", "aaaaaaaavd", "aaaaaaaave", "aaaaaaaavf", "aaaaaaaavg", "aaaaaaaavh", "aaaaaaaavi", "aaaaaaaavj", "aaaaaaaavk", "aaaaaaaavl", "aaaaaaaavm", "aaaaaaaavn", "aaaaaaaavo", "aaaaaaaavp", "aaaaaaaavq", "aaaaaaaavr", "aaaaaaaavs", "aaaaaaaavt", "aaaaaaaavu", "aaaaaaaavv", "aaaaaaaavw", "aaaaaaaavx", "aaaaaaaavy", "aaaaaaaavz", "aaaaaaaawa", "aaaaaaaawb", "aaaaaaaawc", "aaaaaaaawd", "aaaaaaaawe", "aaaaaaaawf", "aaaaaaaawg", "aaaaaaaawh", "aaaaaaaawi", "aaaaaaaawj", "aaaaaaaawk", "aaaaaaaawl", "aaaaaaaawm", "aaaaaaaawn", "aaaaaaaawo", "aaaaaaaawp", "aaaaaaaawq", "aaaaaaaawr", "aaaaaaaaws", "aaaaaaaawt", "aaaaaaaawu", "aaaaaaaawv", "aaaaaaaaww", "aaaaaaaawx", "aaaaaaaawy", "aaaaaaaawz", "aaaaaaaaxa", "aaaaaaaaxb", "aaaaaaaaxc", "aaaaaaaaxd", "aaaaaaaaxe", "aaaaaaaaxf", "aaaaaaaaxg", "aaaaaaaaxh", "aaaaaaaaxi", "aaaaaaaaxj", "aaaaaaaaxk", "aaaaaaaaxl", "aaaaaaaaxm", "aaaaaaaaxn", "aaaaaaaaxo", "aaaaaaaaxp", "aaaaaaaaxq", "aaaaaaaaxr", "aaaaaaaaxs", "aaaaaaaaxt", "aaaaaaaaxu", "aaaaaaaaxv", "aaaaaaaaxw", "aaaaaaaaxx", "aaaaaaaaxy", "aaaaaaaaxz", "aaaaaaaaya", "aaaaaaaayb", "aaaaaaaayc", "aaaaaaaayd", "aaaaaaaaye", "aaaaaaaayf", "aaaaaaaayg", "aaaaaaaayh", "aaaaaaaayi", "aaaaaaaayj", "aaaaaaaayk", "aaaaaaaayl", "aaaaaaaaym", "aaaaaaaayn", "aaaaaaaayo", "aaaaaaaayp", "aaaaaaaayq", "aaaaaaaayr", "aaaaaaaays", "aaaaaaaayt", "aaaaaaaayu", "aaaaaaaayv", "aaaaaaaayw", "aaaaaaaayx", "aaaaaaaayy", "aaaaaaaayz", "aaaaaaaaza", "aaaaaaaazb", "aaaaaaaazc", "aaaaaaaazd", "aaaaaaaaze", "aaaaaaaazf", "aaaaaaaazg", "aaaaaaaazh", "aaaaaaaazi", "aaaaaaaazj", "aaaaaaaazk", "aaaaaaaazl", "aaaaaaaazm", "aaaaaaaazn", "aaaaaaaazo", "aaaaaaaazp", "aaaaaaaazq", "aaaaaaaazr", "aaaaaaaazs", "aaaaaaaazt", "aaaaaaaazu", "aaaaaaaazv", "aaaaaaaazw", "aaaaaaaazx", "aaaaaaaazy", "aaaaaaaazz"];



            var result = search.FindWords(input, words);

            Assert.IsTrue(true);


        }
    }
}