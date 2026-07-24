using SintakseSite.Models;

namespace SintakseSite.Data;

public static class GalleryData
{
    public static List<GalleryViewModel> Galleries => new()
    {
        new GalleryViewModel
        {
            Slug = "cesu-pilsetas-svetki-2026",
            Title = "Cēsu pilsētas svētki",
            Description = "Sintakses Stupora uzstāšanās Cēsu pilsētas svētkos.",
            Date = new DateTime(2026,7,18),

            CoverImage="/images/Gallery/Cesis2026/CesisCover.jpg",

            Images = new()
            {
                "/images/Gallery/Cesis2026/Cesis1.jpg",
                "/images/Gallery/Cesis2026/Cesis2.jpg",
                "/images/Gallery/Cesis2026/Cesis3.jpg",
                "/images/Gallery/Cesis2026/Cesis4.jpg",
                "/images/Gallery/Cesis2026/Cesis5.jpg",
                "/images/Gallery/Cesis2026/Cesis6.jpg",
                "/images/Gallery/Cesis2026/Cesis7.jpg"
            }
        },
        new GalleryViewModel
        {
            Slug = "vienkarsi-sarezgiti-2026",
            Title = "Vienkārši sarežģīti",
            Description = "Sintakses Stupora uzstāšanās RAA mākslas centrā, Veldzes kvartālā.",
            Date = new DateTime(2026,7,23),

            CoverImage="/images/Events/Vnksarezgiti2026/VnksarezgitiMain.jpg",

            Images = new()
            {
                "/images/Events/Vnksarezgiti2026/Vnksarezgiti1.jpg",
                "/images/Events/Vnksarezgiti2026/Vnksarezgiti2.jpg",
                "/images/Events/Vnksarezgiti2026/Vnksarezgiti3.jpg",
                "/images/Events/Vnksarezgiti2026/Vnksarezgiti4.jpg",
                "/images/Events/Vnksarezgiti2026/Vnksarezgiti5.jpg",
                "/images/Events/Vnksarezgiti2026/Vnksarezgiti6.jpg",
                "/images/Events/Vnksarezgiti2026/Vnksarezgiti7.jpg"
            }
        },



    };
}