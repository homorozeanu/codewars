using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace DictionaryMerger
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class DictionaryMergerBenchmarks
    {
        private readonly Dictionary<string, int> one = new Dictionary<string, int> {{"1659541060", 577385424}, {"1964179647", 387822863}, {"1012848999", 139805885}, {"1364570349", 422604025}, {"864644645", 1018328588}, {"745569391", 488308019}, {"1311540073", 1167957314}, {"1223093077", 1751763679}, {"393491112", 1621448082}, {"1728110656", 1680146344}, {"736391539", 1629708774}, {"1516438737", 1158737372}, {"1302452312", 1443694910}, {"233479654", 584085974}, {"623280591", 1894524219}, {"1242862232", 986948035}, {"963594878", 472839628}, {"160461766", 383100425}, {"281070082", 1487078629}, {"137432633", 715615374}, {"929673228", 388805691}, {"946350338", 2085043007}, {"233680395", 690323727}, {"1624180867", 1021192210}, {"1961955616", 930274835}, {"984469938", 1358348466}, {"444965260", 1626986512}, {"1928016131", 29832286}, {"1208430334", 805442275}, {"1232854198", 1716637736}, {"2053809878", 780484375}, {"1946807081", 1117604073}, {"1922950003", 1906105003}, {"1672196788", 838700445}, {"1007495548", 839992652}, {"1470693597", 1053896130}, {"1484015449", 1012495282}, {"750473116", 347585848}, {"683358436", 1578879377}, {"925056977", 612128585}, {"1966997690", 1359771091}, {"769614005", 1840489403}, {"910054281", 2031997413}, {"541982775", 1484092013}, {"692307144", 130629480}, {"1322153738", 1623111454}, {"254224431", 568278544}, {"809289143", 149188853}, {"589482257", 1976229912}};
        private readonly Dictionary<string, int> two = new Dictionary<string, int> {{"162093004", 475059039}, {"1165610586", 785480422}, {"13696662", 1121962964}, {"1607064885", 2078057455}, {"2021816664", 1579953625}, {"876513396", 1580430283}, {"1493957497", 1777034604}, {"2027868945", 620725613}, {"1897123693", 694038787}, {"10870370", 106317678}, {"207549792", 2038436237}, {"1364122228", 188104775}, {"146393301", 876866068}, {"1665322561", 1995065790}, {"799671699", 915736905}, {"203206139", 601284263}, {"1905587238", 854612171}, {"1416786373", 449997938}, {"1594001646", 1181517268}, {"1346074429", 1795134688}, {"233424518", 979480473}, {"10180749", 1109512797}, {"607578617", 1259360508}, {"784155630", 1692602781}, {"1742726156", 1780982465}, {"818638498", 115250356}, {"138318483", 483164579}, {"1768680120", 271140414}, {"1258420458", 977505811}, {"639087121", 1284314241}, {"1604124050", 1759482742}, {"1278385756", 1106079759}, {"1376747486", 275229133}, {"1822326692", 639345326}, {"360248231", 1577871007}, {"1174207614", 715606425}, {"1495448005", 363219329}, {"2020376807", 1375552966}, {"2028255488", 254609431}, {"1728009805", 1034516440}, {"92710438", 2120203427}, {"252339634", 1166172881}, {"97098407", 87955783}, {"462965780", 1422422659}, {"1233415698", 1145645959}, {"1339061127", 616495835}, {"542430147", 61760188}, {"191010638", 621425423}, {"1848578364", 1051584637} };
        private readonly Dictionary<string, int> three = new Dictionary<string, int> {{"1880248958", 332349484}, {"1584517463", 144810304}, {"1332354550", 164855149}, {"606774851", 103032073}, {"767285998", 1922582801}, {"610271419", 393127154}, {"390368573", 1003811027}, {"1396979653", 1752054328}, {"1191603803", 1631404270}, {"1507143108", 112212875}, {"1008981352", 1288791703}, {"1959747000", 399904033}, {"1553413275", 1362085919}, {"238809880", 557711779}, {"173176278", 1433687817}, {"172208691", 1398951384}, {"1674458249", 976670851}, {"521844120", 1395660321}, {"1597482624", 2095383781}, {"787848877", 87484485}, {"559398030", 2141549981}, {"1468153432", 687866626}, {"812151240", 840288544}, {"755277386", 335250100}, {"1366999829", 937859466}, {"1017640032", 707090015}, {"1261765962", 1736365489}, {"42603285", 591457255}, {"520086131", 1184613430}, {"738880676", 2117752278}, {"2073528916", 49063072}, {"2077339442", 1481081828}, {"1750374110", 1358803682}, {"866152552", 1561181369}, {"481966907", 1319332}, {"154571704", 1243703669}, {"843555393", 1419658623}, {"1700298492", 1014915018}, {"1968121918", 1271880374}, {"1735236440", 713124731}, {"606808533", 2051043427}, {"1338195597", 1382800459}, {"416047785", 1612602323}, {"137185422", 2085576407}, {"934067566", 2077870512}, {"875574190", 412869194}, {"1356503105", 817580246}, {"161439216", 510334958}, {"64210539", 2134555251}};
        private readonly Dictionary<string, int> four = new Dictionary<string, int> {{"1084976163", 1600831205}, {"2121619639", 1341579664}, {"2000766840", 1365680497}, {"783287762", 1921420010}, {"2011018269", 1989590986}, {"36066997", 1175171914}, {"770818984", 1395689404}, {"1596860637", 25755945}, {"1510943745", 22485489}, {"858351122", 694538983}, {"1065034043", 137771787}, {"1221618260", 928059792}, {"627113803", 551580042}, {"1273228789", 1889186157}, {"2034684211", 25975147}, {"1258219407", 1189963534}, {"950704479", 1981050314}, {"186904211", 134405235}, {"738988739", 1412712516}, {"50276587", 2119998747}, {"599512697", 642111422}, {"1749067701", 295078083}, {"2049509410", 1906379299}, {"1307051528", 1627368433}, {"963492204", 1330747160}, {"1454120148", 138953727}, {"1799467483", 1517155203}, {"1069521208", 947204376}, {"379212945", 1193559847}, {"714465861", 1449186798}, {"92451708", 1041585252}, {"2034219446", 1985043122}, {"731371579", 993587110}, {"224467435", 937252317}, {"1208785193", 1462455402}, {"1434250853", 98231229}, {"2119692549", 885836022}, {"95026286", 422922621}, {"536187733", 926540177}, {"1026034029", 868218151}, {"1392012161", 1793344003}, {"925693953", 703937051}, {"719338646", 1119265680}, {"1537979698", 1581032923}, {"911529106", 1387183482}, {"1902675937", 1692912539}, {"698246655", 748573436}, {"2027547039", 1705411092}, {"755375623", 1911508226}};
        private readonly Dictionary<string, int> five = new Dictionary<string, int> { {"1711190151", 1055922300}, {"1681911864", 369799211}, {"418583240", 1648520449}, {"2043979954", 1355888919}, {"166744825", 913631461}, {"1422128917", 646598587}, {"411016643", 1600156415}, {"167525818", 1993731357}, {"57174637", 446591352}, {"115891299", 1330282395}, {"1265704476", 1759589546}, {"1603091059", 790918159}, {"25723211", 1969085358}, {"1707263112", 1888821961}, {"1547468221", 1371119113}, {"1005772630", 537098841}, {"1815030645", 772163154}, {"1362833673", 2117595376}, {"1333789934", 1022212950}, {"1374760763", 1424657151}, {"807440744", 1510933374}, {"952520855", 624348237}, {"158904006", 264930519}, {"976166839", 302519522}, {"1525386721", 851998945}, {"691398799", 1580955687}, {"1589519793", 1572576875}, {"645803750", 2099084252}, {"1600314888", 890993705}, {"344076000", 596981529}, {"2088740984", 155157993}, {"1955904345", 943109359}, {"2055342478", 885030076}, {"979051589", 1786337136}, {"237322742", 197414089}, {"659941423", 1182445334}, {"1219314236", 838717795}, {"522841651", 1902254749}, {"807068691", 978742822}, {"632014153", 1908276339}, {"992918519", 1404743590}, {"363435240", 695469276}, {"679720314", 1572300590}, {"1095062695", 242453770}, {"126359404", 1411233068}, {"517280488", 442796229}, {"678136950", 777779234}, {"1483399814", 652282751}, {"1702512676", 9411496}};
        private readonly Dictionary<string, int> six = new Dictionary<string, int> {{"716489406", 1421357577}, {"1433362577", 1337313350}, {"65196780", 1327972632}, {"192057522", 1656437112}, {"361641451", 750801998}, {"1049735224", 891032648}, {"1292015561", 621572066}, {"258979552", 583283308}, {"1751546657", 683997394}, {"1939206400", 1260435069}, {"263389045", 483041888}, {"1937451028", 736597819}, {"1659977732", 973573321}, {"1827617248", 217145194}, {"504308384", 441535002}, {"1502801628", 2018042547}, {"199742073", 797657195}, {"262253416", 1358140223}, {"474913762", 1803088816}, {"1339546810", 1182946255}, {"503411754", 1170766849}, {"1210659139", 344260697}, {"1340202193", 1382810403}, {"119217507", 2043192069}, {"183816677", 94853642}, {"1173716224", 799402420}, {"860559998", 442077607}, {"1893506098", 233447518}, {"1631390196", 696764758}, {"1824819265", 1239107106}, {"1647839031", 2122395975}, {"1152128728", 2067590096}, {"1395484017", 1179176324}, {"691290575", 494358366}, {"359318650", 1048322976}, {"108369546", 2095941488}, {"1491934231", 756260145}, {"757023315", 1240105843}, {"1419866396", 1593190331}, {"1543879273", 277167329}, {"854355814", 1931908826}, {"33328517", 409454742}, {"1415302425", 703399208}, {"1157482549", 1905148113}, {"1051634744", 28805898}, {"1874233674", 1925632651}, {"2125753198", 100439704}, {"1682590871", 528499426}, {"18638121", 1290552690} };
        private readonly Dictionary<string, int> seven = new Dictionary<string, int> {{"1096260327", 161025869}, {"691519828", 1772342788}, {"1683873419", 1282977348}, {"2133967743", 1225258383}, {"1454951836", 104299853}, {"1832537939", 653400255}, {"961064769", 38199865}, {"1300369132", 1547651936}, {"384751292", 1863413852}, {"2089067458", 742673986}, {"652287671", 692084809}, {"21693775", 933626109}, {"1590207269", 330512752}, {"1321572949", 330220542}, {"2117671937", 1391494527}, {"1221152921", 228523889}, {"1221467722", 129313706}, {"496930004", 1382853404}, {"1733131148", 1229496673}, {"248035407", 897834816}, {"422970646", 190044042}, {"1395931019", 1053182696}, {"72610174", 398234489}, {"1215224776", 1836033809}, {"625263519", 578101262}, {"1863172059", 1966660666}, {"586915615", 1423447782}, {"638265019", 404175518}, {"139332094", 1905377366}, {"182135519", 1353360667}, {"2108888046", 1803747201}, {"1255070093", 63457309}, {"1030630579", 1604014050}, {"1579416180", 831751063}, {"1688753508", 2064999375}, {"1962004435", 1302738266}, {"1615378445", 1191232642}, {"319703340", 462243629}, {"1443637437", 1115994726}, {"861015935", 1191972780}, {"1262771623", 1633022787}, {"1852440670", 1539570675}, {"1675806115", 1401975902}, {"1789091921", 1945503587}, {"1638532334", 92754486}, {"1243521310", 1975237429}, {"1047361154", 1042158387}, {"936430417", 766707092}, {"1082457596", 1332473710} };
        private readonly Dictionary<string, int> eight = new Dictionary<string, int> {{"22552117", 616079771}, {"966301956", 383473713}, {"147280301", 707747791}, {"763580474", 560433793}, {"351282221", 1543166620}, {"1103744442", 176021390}, {"1108021728", 1170821015}, {"1044361431", 1137646386}, {"90589044", 475865259}, {"2098790178", 1862983065}, {"535134841", 1776138324}, {"1962405776", 1781396240}, {"1340702376", 1595999022}, {"821478065", 2134250653}, {"255377112", 573220058}, {"254802225", 1700479895}, {"1527269680", 111163727}, {"1093442609", 244936164}, {"225670824", 879297910}, {"1485742486", 1144692879}, {"775990201", 1115372322}, {"1050693681", 245925301}, {"841759145", 1462510944}, {"1132216405", 72700295}, {"930875998", 2057198415}, {"951569343", 460565158}, {"815400561", 1366958178}, {"797338869", 393897440}, {"801157642", 1332389363}, {"1190254984", 698764926}, {"2033753373", 776813468}, {"305056681", 1925545810}, {"1288364395", 1550748194}, {"796235357", 996858001}, {"77378406", 799425267}, {"911975562", 1358774781}, {"1137606420", 954097299}, {"1086992864", 1567246166}, {"725444643", 1716480475}, {"939637095", 2025675079}, {"463782617", 748777770}, {"1203374655", 345662344}, {"1769134362", 1941720714}, {"885079334", 160311502}, {"1461308505", 699545169}, {"1591262169", 1040765108}, {"1836526573", 786977560}, {"1258423153", 2146660380}, {"810315641", 1272631518} };
        private readonly Dictionary<string, int> nine = new Dictionary<string, int> { {"1105044553", 1438494598}, {"666275587", 135358404}, {"2142805536", 131450731}, {"1145222853", 1740278209}, {"1470442385", 2008786909}, {"279965314", 1377576350}, {"1815936444", 1232160814}, {"392752268", 1312063552}, {"234982309", 1284975603}, {"1720922460", 2106877984}, {"156411448", 1494127328}, {"665668860", 635923855}, {"1683033143", 1525316884}, {"1355646745", 2018694101}, {"1669731855", 350628860}, {"1843157793", 1087816131}, {"756930525", 1600296772}, {"611435922", 1648626144}, {"1359399492", 328424213}, {"753455881", 1071923924}, {"1347923138", 28856153}, {"471278329", 1023776072}, {"2027829835", 83732155}, {"1031092372", 359101355}, {"648012840", 524463021}, {"551995251", 2120931197}, {"425737920", 850921304}, {"1116220070", 1758400872}, {"772825738", 30351732}, {"599808908", 617488652}, {"923287633", 1274012399}, {"70546354", 1119813525}, {"165629116", 1339632830}, {"620645825", 215639672}, {"620724892", 891609771}, {"2100147707", 2054041743}, {"531519722", 648998536}, {"758954846", 127555295}, {"1022848999", 1789376435}, {"755577667", 1599300988}, {"494224512", 996545390}, {"1370681261", 1145268834}, {"1946117256", 1869710243}, {"662078211", 2053492868}, {"484076702", 1000518697}, {"875800406", 1329047760}, {"1876098952", 135967229}, {"148636291", 73910739}, {"2105793446", 1498948451}};
        private readonly Dictionary<string, int> ten = new Dictionary<string, int> { {"858146956", 688197005}, {"1610569977", 815452700}, {"1885860110", 1903886716}, {"571798961", 645437155}, {"1589411475", 1924223031}, {"91966458", 988664775}, {"735551873", 1130932950}, {"1422257712", 1147991567}, {"123264140", 2074225890}, {"2050814785", 1072761167}, {"1321179916", 443402520}, {"677554619", 714636604}, {"1879046617", 1767689842}, {"15809365", 771099947}, {"177942791", 395552493}, {"500362245", 685044107}, {"169245496", 1671384195}, {"931229479", 67380662}, {"2136214658", 1826255459}, {"1258168927", 1614278192}, {"573469873", 1300680101}, {"280298768", 885338827}, {"1961526410", 1642895574}, {"264966824", 1892351103}, {"2054273695", 728107385}, {"12703089", 221894048}, {"170579601", 1033032279}, {"177768535", 414744436}, {"10642386", 895933373}, {"1083889730", 118170268}, {"1888077351", 1948182661}, {"467494364", 1193858982}, {"1423860786", 1554405998}, {"819419279", 1211651325}, {"199703471", 1354877050}, {"1159260556", 444492328}, {"816056963", 436536593}, {"499291294", 20499815}, {"163103752", 1939699439}, {"900593841", 236151043}, {"1502723018", 270941909}, {"864309899", 1597319053}, {"382849404", 278468197}, {"514464506", 1283696864}, {"1493615660", 516485043}, {"56738276", 1240281285}, {"742365729", 1139998659}, {"1873684488", 772770859}, {"833185737", 1233923433}};
        private readonly Dictionary<string, int> eleven = new Dictionary<string, int> { {"1608961688", 407120412}, {"823476295", 1200799146}, {"1692647632", 699396645}, {"1716330476", 1715694408}, {"1553320732", 1881526655}, {"533740985", 157268720}, {"251640684", 218426594}, {"2142823179", 847738687}, {"762930897", 1617135442}, {"1083872762", 1017658958}, {"811009578", 1145392589}, {"1039941492", 1683206062}, {"1865519312", 1830702075}, {"1298138774", 2066462918}, {"1849610246", 1823541951}, {"710335752", 1874004082}, {"1334797725", 1076663966}, {"330737751", 493473429}, {"1560158395", 301923872}, {"725777924", 164913254}, {"2028472224", 814638643}, {"872631112", 780421498}, {"749955879", 1336346940}, {"264844359", 1985795329}, {"1244941753", 2042110689}, {"377067762", 256549046}, {"1836381744", 1963010426}, {"422913855", 463569099}, {"1514662567", 1287753880}, {"1482763481", 2009429204}, {"1548741518", 1797351205}, {"2013567809", 1877262428}, {"1171190903", 807220550}, {"969954642", 1322460365}, {"2035172490", 1649349750}, {"1435063939", 461007025}, {"891357518", 918959508}, {"1136670381", 2143854582}, {"272761477", 259519994}, {"933250183", 529172372}, {"1565857716", 1459827092}, {"821521165", 1954983204}, {"1446474189", 453786706}, {"37622338", 1519270946}, {"653750111", 2014652299}, {"1126294509", 272404515}, {"966644038", 863832367}, {"763655383", 231121019}, {"948554481", 1142852331}};
        private readonly Dictionary<string, int> twelve = new Dictionary<string, int> { {"1756714242", 2090218976}, {"366392298", 1089867641}, {"2098106486", 1743075650}, {"607046750", 2063544384}, {"1512675175", 917422236}, {"826340045", 426542920}, {"190807622", 1255142573}, {"354503697", 953591109}, {"443571488", 88914426}, {"975830040", 58584605}, {"430788239", 717404197}, {"769598212", 1598167343}, {"668710254", 20520191}, {"523055241", 1162659424}, {"1641846634", 27525151}, {"155304125", 905549362}, {"1195300101", 1277392793}, {"650289399", 990514854}, {"162780074", 475990075}, {"1509204253", 1225929162}, {"1347936454", 1530413452}, {"1088595178", 1267683749}, {"692930901", 227207191}, {"1823844677", 2018635583}, {"2065384465", 13052929}, {"420260879", 674740957}, {"1402774626", 889969876}, {"712064092", 1039310045}, {"1320620764", 915708602}, {"421157387", 2077586295}, {"1220020409", 1591870973}, {"421697750", 1485150024}, {"762118111", 2068274330}, {"1378726466", 1060898476}, {"604853174", 1511472490}, {"790811035", 2115065060}, {"727193820", 1897384525}, {"858131798", 1047858434}, {"1776292666", 1649398110}, {"905236442", 441503063}, {"344159161", 651903305}, {"1244758606", 1628793705}, {"1754747919", 1628046815}, {"1650258383", 305330225}, {"565328701", 1758463001}, {"1817377737", 1394555119}, {"54832688", 1579101605}, {"5908753", 1903549128}, {"1108715702", 1750928801} };
        private readonly Dictionary<string, int> thirteen = new Dictionary<string, int> {{"505565638", 772140218}, {"995964372", 762946201}, {"1413782409", 553911975}, {"1369725541", 452679466}, {"2095030784", 1652873748}, {"31838078", 1811689305}, {"1410501026", 1818706301}, {"10472160", 2127137971}, {"1733427134", 568117104}, {"347112367", 940387692}, {"1877885752", 1281554943}, {"418015947", 1073396241}, {"495569775", 993873820}, {"1841578400", 1543739563}, {"2060232372", 1295575862}, {"1891475772", 1102066317}, {"2086626379", 25363865}, {"1143832472", 133096224}, {"1593022338", 1728696607}, {"1385604543", 690846631}, {"259068164", 1302068453}, {"1680499678", 2144868282}, {"273492147", 901123043}, {"347961975", 2146155083}, {"1384082959", 75178364}, {"1993158118", 1585275296}, {"1556436761", 168328010}, {"2020526696", 1371494342}, {"354124271", 2070051778}, {"267376426", 419908589}, {"859817222", 1973469625}, {"539930741", 799454922}, {"1908881623", 1077255408}, {"1872546573", 1385137161}, {"674873829", 2024859583}, {"534115633", 4730527}, {"1329996208", 1803749383}, {"681319528", 575817299}, {"1748538912", 420631312}, {"799904094", 1741930379}, {"645911845", 1842906964}, {"159656604", 1985054008}, {"1449901391", 306200476}, {"1693113203", 1918298369}, {"152320816", 1919821777}, {"1926455600", 1670454207}, {"1461320181", 965695954}, {"1978513056", 433082186}, {"762137712", 881044756} };
        private readonly Dictionary<string, int> fourteen = new Dictionary<string, int> { {"235986659", 1343720386}, {"1176060117", 1110308461}, {"1471281254", 1506707023}, {"1688546378", 1988427591}, {"255279088", 1900171025}, {"1634492129", 1444709397}, {"1770439077", 2080976606}, {"1270147684", 672929694}, {"1921480391", 1164393905}, {"1813813021", 702360380}, {"1497037178", 1602681147}, {"1531625852", 2101731851}, {"1232816345", 902535699}, {"98403983", 1011145073}, {"690893993", 364300254}, {"1972719974", 248237342}, {"1961163234", 867494156}, {"184644653", 1603667355}, {"565870262", 1683087031}, {"371625710", 800433228}, {"296507630", 1608957447}, {"50921388", 1940425825}, {"283806240", 855095066}, {"149382700", 1992962641}, {"400306523", 788390487}, {"1191699210", 814119151}, {"766752812", 59777332}, {"1531491225", 780789159}, {"1959578181", 1221811913}, {"2024975763", 568745555}, {"1408303040", 677401305}, {"1297533598", 2038462481}, {"2074934698", 1386254787}, {"1631029810", 902944921}, {"1896331953", 1813963976}, {"107059432", 238393360}, {"792768195", 1013379793}, {"405852750", 2035563378}, {"1551759759", 1738683674}, {"1817925611", 377721279}, {"753152999", 252924989}, {"610838550", 2049987153}, {"1320084691", 1158600823}, {"1628968177", 1901385902}, {"1483486578", 1551339141}, {"1791572821", 1491541996}, {"1805594915", 1950363802}, {"1539613835", 1766589972}, {"311423849", 159942554}};
        private readonly Dictionary<string, int> fifteen = new Dictionary<string, int> { {"2012974774", 1045035100}, {"1371548903", 1393921426}, {"96630688", 733826194}, {"681331055", 953305850}, {"21350956", 1900856666}, {"1801408229", 1643411494}, {"1376513047", 220894507}, {"1551369949", 1647254484}, {"1963076203", 1155378051}, {"66562755", 1395030092}, {"718377790", 916333875}, {"1904770257", 1877127555}, {"1566941990", 344992812}, {"22391155", 763001083}, {"580282092", 989888040}, {"1621249605", 786746425}, {"1724139529", 1391817205}, {"1873192547", 772890511}, {"1153656023", 1506715220}, {"156294301", 2024496003}, {"1368656098", 366778841}, {"1137249867", 1875595158}, {"99977673", 1987558731}, {"174826094", 1570678314}, {"2087655694", 158340431}, {"2134771246", 384235784}, {"1700027217", 1063877404}, {"1589048411", 1096640899}, {"1287748490", 1641904995}, {"1974463083", 1899121523}, {"711435039", 2065813619}, {"373023758", 1178946563}, {"279607061", 1014661804}, {"2066755612", 2132179489}, {"495185607", 778479438}, {"493598461", 456360983}, {"999083750", 189550399}, {"26373994", 351598949}, {"1926567655", 29175099}, {"1777149882", 1726866906}, {"170166718", 599196488}, {"822829036", 421941661}, {"1002600441", 1237013821}, {"1234202855", 660262125}, {"1950252441", 776551648}, {"1632625668", 1659234675}, {"1679735784", 404656425}, {"1313060964", 1450326126}, {"2141238730", 2105786951}};
        private readonly Dictionary<string, int> sixteen = new Dictionary<string, int> { {"1595988097", 1232799516}, {"2068286766", 190130252}, {"1075492707", 1309176256}, {"1812225617", 1678410263}, {"1532635681", 1510476818}, {"1037503410", 1237449462}, {"1317556891", 1258573391}, {"2012238760", 247596177}, {"1728954805", 112238551}, {"1242984583", 2098565744}, {"176346122", 1190076887}, {"1927942596", 1406493487}, {"181927048", 1866117606}, {"1293337417", 981847433}, {"924108846", 594427325}, {"1023973082", 723531515}, {"357843866", 1968264351}, {"580670649", 544350366}, {"1806063787", 2127520113}, {"1671187428", 1661136427}, {"757199691", 1471673825}, {"1851861787", 1871209684}, {"1770242362", 712802979}, {"1606478404", 374052277}, {"1794479562", 1432139607}, {"823185267", 1200822413}, {"207341543", 42672986}, {"1929440829", 405911210}, {"1452340567", 661793279}, {"8203204", 1356858748}, {"15838839", 830378184}, {"754301417", 938208356}, {"486503736", 313971895}, {"879605596", 1496776187}, {"677902742", 1467888394}, {"589016037", 1748918339}, {"588534770", 1729331803}, {"1341366053", 852155944}, {"1485698747", 56732912}, {"1783734772", 1616607716}, {"259639202", 919285140}, {"1334851518", 1639452886}, {"1918725705", 1970634316}, {"516189972", 315170880}, {"38823522", 174759439}, {"1239493446", 1144270508}, {"2119316909", 314328680}, {"1645297588", 2074305154}, {"717372408", 913653431} };
        private readonly Dictionary<string, int> seventeen = new Dictionary<string, int> { {"1384705948", 1456270467}, {"1980681030", 109702217}, {"1843633182", 326591168}, {"843123570", 1221750575}, {"612287643", 625493387}, {"848790580", 1077284885}, {"1067696110", 1395607655}, {"1025542154", 539079135}, {"1097219546", 1244037346}, {"1643010313", 1262332178}, {"1166966298", 663353067}, {"1945265570", 564434716}, {"1457952665", 503143303}, {"228394948", 1592229176}, {"1777085077", 274206090}, {"84034215", 1414544546}, {"134783536", 572045316}, {"819510611", 327464305}, {"1783410333", 149936985}, {"1223135605", 1008260350}, {"796329316", 696975130}, {"1358346673", 2038180232}, {"1613863947", 1109022284}, {"1254546976", 1991369438}, {"118728354", 1580237774}, {"1364592781", 401260242}, {"431294841", 1602523877}, {"1894170780", 721352881}, {"1658488544", 1416246314}, {"799233199", 1340489879}, {"98196220", 1398378041}, {"1592149145", 338081553}, {"541459172", 1581729681}, {"942501349", 495650794}, {"576097044", 698077849}, {"903152449", 947282561}, {"20901741", 634749963}, {"466002862", 469991168}, {"1452490041", 2054568985}, {"1098054416", 348930381}, {"1396079974", 384509157}, {"1473500822", 196847303}, {"1057096956", 1830257620}, {"983249705", 679743306}, {"825358183", 98157730}, {"816459408", 367164019}, {"1498187433", 2030129373}, {"910064130", 1545434922}, {"1252309632", 1020265120} };
        private readonly Dictionary<string, int> eighteen = new Dictionary<string, int> { {"1496721060", 32134266}, {"166520935", 758896182}, {"1415272394", 1568134152}, {"677085325", 417310220}, {"380358501", 1944028525}, {"1136521015", 1424179612}, {"1416346487", 1751403206}, {"318191898", 450302818}, {"2091893552", 1861170710}, {"2072360866", 1395301842}, {"1428468244", 858685199}, {"598479976", 262758043}, {"1817776258", 477939314}, {"2029102088", 535988430}, {"1596578775", 138256015}, {"1872169480", 1068051587}, {"1365165183", 432224921}, {"557847925", 1065920150}, {"182409446", 637183792}, {"1116720410", 2052850317}, {"1667245625", 639786736}, {"1449899119", 1186704827}, {"1690705938", 1548662218}, {"829294890", 1212539849}, {"48972121", 1047884615}, {"2085719468", 1196377067}, {"1620557703", 2004491437}, {"1739280523", 638035861}, {"1581137937", 2051246539}, {"1088603571", 937333080}, {"1686515711", 141096895}, {"968215092", 242102486}, {"71859045", 68469428}, {"59014429", 984121566}, {"1193555281", 1399755395}, {"267893372", 1454709760}, {"744450300", 19510549}, {"1875539864", 788681508}, {"1556269727", 1559258796}, {"719535752", 269114040}, {"1796128071", 816562239}, {"487016309", 548694160}, {"200020194", 675792413}, {"1594977531", 1508157393}, {"840428045", 2067295711}, {"1632265860", 278646554}, {"1696063868", 179387330}, {"366334606", 1526148730}, {"1819055291", 1207796633}};
        private readonly Dictionary<string, int> nineteen = new Dictionary<string, int> { {"1114845782", 1622236510}, {"1489647789", 1992656971}, {"18984568", 796700373}, {"779991243", 631009708}, {"451926767", 1601047154}, {"128951573", 950599015}, {"1229249781", 21879141}, {"1331710787", 819489531}, {"1288688656", 869953472}, {"1801564233", 419520932}, {"42082292", 1543550279}, {"620975544", 698340683}, {"143693521", 1273743217}, {"1914973182", 2136730465}, {"1906129539", 565062970}, {"1800659590", 349391134}, {"1117109864", 348473094}, {"444413014", 1244782889}, {"926949898", 1950954747}, {"797577671", 1837799583}, {"1916186564", 1716494133}, {"223865646", 2141414024}, {"1379205820", 2037312677}, {"838045930", 1610386719}, {"1094419414", 876574337}, {"1038182321", 1643864781}, {"1872068144", 1399534359}, {"1165714341", 1718779150}, {"1001260966", 791307106}, {"1848963450", 892724998}, {"1029210838", 790744425}, {"872363816", 2034347444}, {"1947871211", 1927044086}, {"1980972798", 880776687}, {"1724949774", 86927898}, {"2040023280", 1485217556}, {"72375801", 2111248297}, {"650818015", 473071806}, {"1319684633", 627045167}, {"1466618510", 253864491}, {"435697287", 304586463}, {"1042311051", 1029555202}, {"1674364296", 156794809}, {"624806637", 1865059152}, {"1330242400", 873117511}, {"243521923", 135642792}, {"101991297", 2052336320}, {"808588745", 1125442139}, {"844130317", 337001849}};
        private readonly Dictionary<string, int> twenty = new Dictionary<string, int> { {"193542813", 1599645381}, {"56339879", 2104752890}, {"2032920592", 1007491516}, {"984034704", 1700448412}, {"1571488980", 1908303494}, {"748716344", 692642535}, {"399094517", 374215799}, {"1472172243", 1595098959}, {"457027711", 724624375}, {"1895917021", 1990292261}, {"359983148", 1791076402}, {"1302237449", 115913646}, {"1698017934", 851832263}, {"1990889622", 1904380488}, {"1383226259", 167523128}, {"1302659552", 1672859523}, {"1776425136", 982682784}, {"433502354", 2014456776}, {"197524612", 478428044}, {"419149518", 34819535}, {"45520498", 2121399531}, {"732789476", 863986790}, {"1116342808", 637599865}, {"474022994", 2016789771}, {"810954196", 654375985}, {"1595308609", 83964370}, {"1377008765", 1001321703}, {"2124502348", 549950058}, {"297407932", 2087909880}, {"406734956", 1181088329}, {"1164085541", 1227137863}, {"317222153", 1403965852}, {"605643942", 1223340468}, {"1063701046", 1563895380}, {"2088197092", 1605199114}, {"1397574347", 2126083314}, {"305474857", 1861097486}, {"1944771763", 386067264}, {"1058286926", 438250659}, {"1147054485", 1060418069}, {"377809269", 2121583498}, {"1093426292", 728850274}, {"719698166", 1218695182}, {"295850758", 775103433}, {"1005664083", 2031035943}, {"1717048844", 257098379}, {"71693088", 1385544836}, {"1018217641", 965866282}, {"1804177378", 1476307271}};
        
        [Benchmark(Baseline = true)]
        public void MergeByGrouping()
        {
            DictionaryMerger.MergeByGrouping(this.one, this.two, this.three, this.four, this.five, 
                this.six, this.seven, this.eight, this.nine, this.ten, this.eleven, this.twenty, this.thirteen, 
                this.fourteen, this.fifteen, this.sixteen, this.seventeen, this.eighteen, this.nineteen, this.twenty);
        }

        [Benchmark]
        public void MergeByAggregating()
        {
            DictionaryMerger.MergeByAggregating(this.one, this.two, this.three, this.four, this.five, 
                this.six, this.seven, this.eight, this.nine, this.ten, this.eleven, this.twenty, this.thirteen, 
                this.fourteen, this.fifteen, this.sixteen, this.seventeen, this.eighteen, this.nineteen, this.twenty);
        }

        [Benchmark]
        public void MergeByIterating()
        {
            DictionaryMerger.MergeByIterating(this.one, this.two, this.three, this.four, this.five, 
                this.six, this.seven, this.eight, this.nine, this.ten, this.eleven, this.twenty, this.thirteen, 
                this.fourteen, this.fifteen, this.sixteen, this.seventeen, this.eighteen, this.nineteen, this.twenty);
        }

        [Benchmark]
        public void MergeByKartoffelsalat()
        {
            DictionaryMerger.MergeByKartoffelsalat(this.one, this.two, this.three, this.four, this.five, 
                this.six, this.seven, this.eight, this.nine, this.ten, this.eleven, this.twenty, this.thirteen, 
                this.fourteen, this.fifteen, this.sixteen, this.seventeen, this.eighteen, this.nineteen, this.twenty);
        }

        [Benchmark]
        public void MergeByBlune()
        {
            DictionaryMerger.MergeByBlune(this.one, this.two, this.three, this.four, this.five, 
                this.six, this.seven, this.eight, this.nine, this.ten, this.eleven, this.twenty, this.thirteen, 
                this.fourteen, this.fifteen, this.sixteen, this.seventeen, this.eighteen, this.nineteen, this.twenty);
        }
    }
}