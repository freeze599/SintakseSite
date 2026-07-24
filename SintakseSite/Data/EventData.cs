using SintakseSite.Models;

namespace SintakseSite.Data;

public static class EventData
{
    public static List<EventViewModel> Events => new()
    {
        new EventViewModel
        {
            Slug = "cesu-pilsetas-svetki-2026",
            Title = "Cēsu pilsētas svētki",
            Date = new DateTime(2026, 7, 18),
            Time = "17:00",

            Description =
                "K-Sils un Sintakses Stupors Cēsu pilsētas svētku programmā.",

            PosterImage =
                "/images/Events/Cesis2026/cesis2026-18-07.png",

            ExternalUrl =
                "https://pasakumi.cesis.lv/pasakums/svetki-cesis-820/",

            ExternalLinkText = "Plašāka informācija",

            GallerySlug = "cesu-pilsetas-svetki-2026"
        },

        new EventViewModel
        {
            Slug = "vienkarsi-sarezgiti-2026",
            Title = "Vienkārši sarežģīti",
            Date = new DateTime(2026, 7, 23),
            Time = "19:30",

            Description =
                "Kultūras telpā RAA norisināsies dzejas vakars, " +
                "iedvesmojoties no šaha spēles un situācijām, " +
                "kas ir vienkārši sarežģītas.",

            PosterImage =
                "/images/Events/RAA23072026/vienkarsi_sarezgiti.jpg",

            ExternalUrl =
                "https://www.instagram.com/raa_riga/",

            ExternalLinkText = "Kultūras telpa RAA",

            Participants =
                "Evelīna Mūrniece, Džonatans Melgalvis, Dainis Deigelis, " +
                "Linda Tīmane, Andris Alps, Laima Ābele, Ilze Kuzmicka, " +
                "Kristīne Jučkoviča un Dita Putniņa.",

            MusicalGuest = "Zoya Zoyroko",

            GallerySlug = "vienkarsi-sarezgiti-2026"
        },
        new EventViewModel
{
    Slug = "vel-apmacies-2026",

    Title = "Grāmatas \"vēl apmācies\" atvēršanas svētki",

    Date = new DateTime(2026, 8, 7),

    Time = "19:00",

    Description =
        "Sērijā \"Orbītas bibliotēka\" iznācis Andra Alpa dzejas krājums \"vēl apmācies\". " +
        "Veldzes pagrabos paredzēti autora lasījumi, ko papildinās mākslinieka Artūra Puntes " +
        "pilsētas skaņu kompozīcijas un Vārnas kokles spēle. Vakara gaitā dosimies uz " +
        "netālajām RAA telpām, kur norisināsies pasākuma otrā daļa – krājuma redaktora " +
        "Ivara Šteinberga, Orbītas un Andra Alpa uzrunas. Aptuveni plkst. 20.30 paredzēti " +
        "dzejas grupas \"Sintakses Stupors\" biedru un draugu lasījumi.",

    PosterImage = "/images/Events/VelApmacies2026/Aalps.jpg",

    ExternalUrl = "https://www.facebook.com/events/2211939899628958/",

    ExternalLinkText = "Facebook pasākums",

    Participants =
        "Valters Liberts, Pauls Kauķis, Laima Ābele, Meldra Ķemere, " +
        "Lauris Bērziņš, Dainis Deigelis, Kristīne Jučkoviča un citi.",

    MusicalGuest = "Artūrs Punte (pilsētas skaņu kompozīcijas) un Vārna (kokles spēle)",

    GallerySlug = null
},
    };
}