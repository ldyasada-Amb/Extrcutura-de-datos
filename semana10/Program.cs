using System;
using System.Collections.Generic;
using System.Linq;

class ProgramaVacunacion
{
    static void Main()
    {
        // Conjunto de 500 ciudadanos (vacunado1 al vacunado500)
        var ciudadanos = new HashSet<string>
        {
            "vacunado1","vacunado2","vacunado3","vacunado4","vacunado5",
            "vacunado6","vacunado7","vacunado8","vacunado9","vacunado10",
            "vacunado11","vacunado12","vacunado13","vacunado14","vacunado15",
            "vacunado16","vacunado17","vacunado18","vacunado19","vacunado20",
            "vacunado21","vacunado22","vacunado23","vacunado24","vacunado25",
            "vacunado26","vacunado27","vacunado28","vacunado29","vacunado30",
            "vacunado31","vacunado32","vacunado33","vacunado34","vacunado35",
            "vacunado36","vacunado37","vacunado38","vacunado39","vacunado40",
            "vacunado41","vacunado42","vacunado43","vacunado44","vacunado45",
            "vacunado46","vacunado47","vacunado48","vacunado49","vacunado50", 
            "vacunado51","vacunado52","vacunado53","vacunado54","vacunado55", 
            "vacunado56","vacunado57","vacunado58","vacunado59","vacunado60", 
            "vacunado61","vacunado62","vacunado63","vacunado64","vacunado65", 
            "vacunado66","vacunado67","vacunado68","vacunado69","vacunado70", 
            "vacunado71","vacunado72","vacunado73","vacunado74","vacunado75", 
            "vacunado76","vacunado77","vacunado78","vacunado79","vacunado80", 
            "vacunado81","vacunado82","vacunado83","vacunado84","vacunado85", 
            "vacunado86","vacunado87","vacunado88","vacunado89","vacunado90", 
            "vacunado91","vacunado92","vacunado93","vacunado94","vacunado95", 
            "vacunado96","vacunado97","vacunado98","vacunado99","vacunado100",
            "vacunado101","vacunado102","vacunado103","vacunado104","vacunado105",
            "vacunado106","vacunado107","vacunado108","vacunado109","vacunado110",
            "vacunado111","vacunado112","vacunado113","vacunado114","vacunado115",
            "vacunado116","vacunado117","vacunado118","vacunado119","vacunado120",
            "vacunado121","vacunado122","vacunado123","vacunado124","vacunado125",
            "vacunado126","vacunado127","vacunado128","vacunado129","vacunado130",
            "vacunado131","vacunado132","vacunado133","vacunado134","vacunado135",
            "vacunado136","vacunado137","vacunado138","vacunado139","vacunado140",
            "vacunado141","vacunado142","vacunado143","vacunado144","vacunado145",
            "vacunado146","vacunado147","vacunado148","vacunado149","vacunado150",
            "vacunado151","vacunado152","vacunado153","vacunado154","vacunado155",
            "vacunado156","vacunado157","vacunado158","vacunado159","vacunado160",
            "vacunado161","vacunado162","vacunado163","vacunado164","vacunado165",
            "vacunado166","vacunado167","vacunado168","vacunado169","vacunado170",
            "vacunado171","vacunado172","vacunado173","vacunado174","vacunado175",
            "vacunado176","vacunado177","vacunado178","vacunado179","vacunado180",
            "vacunado181","vacunado182","vacunado183","vacunado184","vacunado185",
            "vacunado186","vacunado187","vacunado188","vacunado189","vacunado190",
            "vacunado191","vacunado192","vacunado193","vacunado194","vacunado195",
            "vacunado196","vacunado197","vacunado198","vacunado199","vacunado200",
            "vacunado201","vacunado202","vacunado203","vacunado204","vacunado205",
            "vacunado206","vacunado207","vacunado208","vacunado209","vacunado210",
            "vacunado211","vacunado212","vacunado213","vacunado214","vacunado215",
            "vacunado216","vacunado217","vacunado218","vacunado219","vacunado220",
            "vacunado221","vacunado222","vacunado223","vacunado224","vacunado225",
            "vacunado226","vacunado227","vacunado228","vacunado229","vacunado230",
            "vacunado231","vacunado232","vacunado233","vacunado234","vacunado235",
            "vacunado236","vacunado237","vacunado238","vacunado239","vacunado240",
            "vacunado241","vacunado242","vacunado243","vacunado244","vacunado245",
            "vacunado246","vacunado247","vacunado248","vacunado249","vacunado250",
            "vacunado251","vacunado252","vacunado253","vacunado254","vacunado255",
            "vacunado256","vacunado257","vacunado258","vacunado259","vacunado260",
            "vacunado261","vacunado262","vacunado263","vacunado264","vacunado265",
            "vacunado266","vacunado267","vacunado268","vacunado269","vacunado270",
            "vacunado271","vacunado272","vacunado273","vacunado274","vacunado275",
            "vacunado276","vacunado277","vacunado278","vacunado279","vacunado280",
            "vacunado281","vacunado282","vacunado283","vacunado284","vacunado285",
            "vacunado286","vacunado287","vacunado288","vacunado289","vacunado290",
            "vacunado291","vacunado292","vacunado293","vacunado294","vacunado295",
            "vacunado296","vacunado297","vacunado298","vacunado299","vacunado300",
            "vacunado301","vacunado302","vacunado303","vacunado304","vacunado305",
            "vacunado306","vacunado307","vacunado308","vacunado309","vacunado310",
            "vacunado311","vacunado312","vacunado313","vacunado314","vacunado315",
            "vacunado316","vacunado317","vacunado318","vacunado319","vacunado320",
            "vacunado321","vacunado322","vacunado323","vacunado324","vacunado325",
            "vacunado326","vacunado327","vacunado328","vacunado329","vacunado330",
            "vacunado331","vacunado332","vacunado333","vacunado334","vacunado335",
            "vacunado336","vacunado337","vacunado338","vacunado339","vacunado340",
            "vacunado341","vacunado342","vacunado343","vacunado344","vacunado345",
            "vacunado346","vacunado347","vacunado348","vacunado349","vacunado350",
            "vacunado351","vacunado352","vacunado353","vacunado354","vacunado355",
            "vacunado356","vacunado357","vacunado358","vacunado359","vacunado360",
            "vacunado361","vacunado362","vacunado363","vacunado364","vacunado365",
            "vacunado366","vacunado367","vacunado368","vacunado369","vacunado370",
            "vacunado371","vacunado372","vacunado373","vacunado374","vacunado375",
            "vacunado376","vacunado377","vacunado378","vacunado379","vacunado380",
            "vacunado381","vacunado382","vacunado383","vacunado384","vacunado385",
            "vacunado386","vacunado387","vacunado388","vacunado389","vacunado390",
            "vacunado391","vacunado392","vacunado393","vacunado394","vacunado395",
            "vacunado396","vacunado397","vacunado398","vacunado399","vacunado400",
            "vacunado401","vacunado402","vacunado403","vacunado404","vacunado405",
            "vacunado406","vacunado407","vacunado408","vacunado409","vacunado410",
            "vacunado411","vacunado412","vacunado413","vacunado414","vacunado415",
            "vacunado416","vacunado417","vacunado418","vacunado419","vacunado420",
            "vacunado421","vacunado422","vacunado423","vacunado424","vacunado425",
            "vacunado426","vacunado427","vacunado428","vacunado429","vacunado430",
            "vacunado431","vacunado432","vacunado433","vacunado434","vacunado435",
            "vacunado436","vacunado437","vacunado438","vacunado439","vacunado440",
            "vacunado441","vacunado442","vacunado443","vacunado444","vacunado445",
            "vacunado446","vacunado447","vacunado448","vacunado449","vacunado450",
            "vacunado451","vacunado452","vacunado453","vacunado454","vacunado455",
            "vacunado456","vacunado457","vacunado458","vacunado459","vacunado460",
            "vacunado461","vacunado462","vacunado463","vacunado464","vacunado465",
            "vacunado466","vacunado467","vacunado468","vacunado469","vacunado470",
            "vacunado471","vacunado472","vacunado473","vacunado474","vacunado475",
            "vacunado476","vacunado477","vacunado478","vacunado479","vacunado480",
            "vacunado481","vacunado482","vacunado483","vacunado484","vacunado485",
            "vacunado486","vacunado487","vacunado488","vacunado489","vacunado490",
            "vacunado491","vacunado492","vacunado493","vacunado494","vacunado495",
            "vacunado496","vacunado497","vacunado498","vacunado499","vacunado500"
        };

        // Conjunto de 75 ciudadanos vacunados con Pfizer
        var vacunadosPfizer = new HashSet<string>
        {
            "vacunado1","vacunado2","vacunado3","vacunado4","vacunado5",
            "vacunado6","vacunado7","vacunado8","vacunado9","vacunado10",
            "vacunado11","vacunado12","vacunado13","vacunado14","vacunado15",
            "vacunado16","vacunado17","vacunado18","vacunado19","vacunado20",
            "vacunado21","vacunado22","vacunado23","vacunado24","vacunado25",
            "vacunado26","vacunado27","vacunado28","vacunado29","vacunado30",
            "vacunado31","vacunado32","vacunado33","vacunado34","vacunado35",
            "vacunado36","vacunado37","vacunado38","vacunado39","vacunado40",
            "vacunado41","vacunado42","vacunado43","vacunado44","vacunado45",
            "vacunado46","vacunado47","vacunado48","vacunado49","vacunado50",
            "vacunado51","vacunado52","vacunado53","vacunado54","vacunado55",
            "vacunado56","vacunado57","vacunado58","vacunado59","vacunado60",
            "vacunado61","vacunado62","vacunado63","vacunado64","vacunado65",
            "vacunado66","vacunado67","vacunado68","vacunado69","vacunado70",
            "vacunado71","vacunado72","vacunado73","vacunado74","vacunado75"
        };

        // Conjunto de 75 ciudadanos vacunados con AstraZeneca
        var vacunadosAstraZeneca = new HashSet<string>
        {
            "vacunado50","vacunado51","vacunado52","vacunado53","vacunado54",
            "vacunado55","vacunado56","vacunado57","vacunado58","vacunado59",
            "vacunado60","vacunado61","vacunado62","vacunado63","vacunado64",
            "vacunado65","vacunado66","vacunado67","vacunado68","vacunado69",
            "vacunado70","vacunado71","vacunado72","vacunado73","vacunado74",
            "vacunado75","vacunado76","vacunado77","vacunado78","vacunado79",
            "vacunado80","vacunado81","vacunado82","vacunado83","vacunado84",
            "vacunado85","vacunado86","vacunado87","vacunado88","vacunado89",
            "vacunado90","vacunado91","vacunado92","vacunado93","vacunado94",
            "vacunado95","vacunado96","vacunado97","vacunado98","vacunado99",
            "vacunado100","vacunado101","vacunado102","vacunado103","vacunado104",
            "vacunado105","vacunado106","vacunado107","vacunado108","vacunado109",
            "vacunado110","vacunado111","vacunado112","vacunado113","vacunado114",
            "vacunado115","vacunado116","vacunado117","vacunado118","vacunado119",
            "vacunado120","vacunado121","vacunado122","vacunado123","vacunado124"
        };

        // Operaciones de conjuntos
        var noVacunados = ciudadanos.Except(vacunadosPfizer.Union(vacunadosAstraZeneca));
        var ambasDosis = vacunadosPfizer.Intersect(vacunadosAstraZeneca);
        var soloPfizer = vacunadosPfizer.Except(vacunadosAstraZeneca);
        var soloAstraZeneca = vacunadosAstraZeneca.Except(vacunadosPfizer);

        // Mostrar resultados
        Console.WriteLine("Ciudadanos no vacunados: " + noVacunados.Count());
        Console.WriteLine("Ciudadanos con ambas dosis: " + ambasDosis.Count());
        Console.WriteLine("Ciudadanos solo Pfizer: " + soloPfizer.Count());
        Console.WriteLine("Ciudadanos solo AstraZeneca: " + soloAstraZeneca.Count());
    }
}
