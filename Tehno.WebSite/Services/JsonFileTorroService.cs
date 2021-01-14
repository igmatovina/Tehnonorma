using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using Tehno.WebSite.Models;

namespace Tehno.WebSite.Services
{
    public class JsonFileTorroService
    {
        public JsonFileTorroService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "torro.json"); }
        }

        private string JsonFileNameHD
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "HD.json"); }
        }

        public IEnumerable<Torro> GetTorro()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }
                    );
            }
        }

        public IEnumerable<Torro> GetHD()
        {
            using (var jsonFileReader = File.OpenText(JsonFileNameHD))
            {
                return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }
                    );
            }
        }

        private string JsonFileNameS
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "S.json"); }
        }

        public IEnumerable<Torro> GetS()
        {
            using (var jsonFileReader = File.OpenText(JsonFileNameS))
            {
                return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }
                    );
            }
        }

        private string JsonFileNameGBS
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "GBS.json"); }
        }

        public IEnumerable<Torro> GetGBS()
        {
            using (var jsonFileReader = File.OpenText(JsonFileNameGBS))
            {
                return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }
                    );
            }
        }

        private string JsonFileNameCOBRA
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "COBRA.json"); }
        }

        public IEnumerable<Torro> GetCOBRA()
        {
            using (var jsonFileReader = File.OpenText(JsonFileNameCOBRA))
            {
                return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }
                    );
            }
        }

        private string JsonFileNameFBS
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "FBS.json"); }
        }

        public IEnumerable<Torro> GetFBS()
        {
            using (var jsonFileReader = File.OpenText(JsonFileNameFBS))
            {
                return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }
                    );
            }
        }

        private string JsonFileNameSVS
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "SVS.json"); }
        }

        public IEnumerable<Torro> GetSVS()
        {
            using (var jsonFileReader = File.OpenText(JsonFileNameSVS))
            {
                return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }
                    );
            }
        }

        private string JsonFileNameFILTER
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "FILTER.json"); }
        }

        public IEnumerable<Torro> GetFILTER()
        {
            using (var jsonFileReader = File.OpenText(JsonFileNameFILTER))
            {
                return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }
                    );
            }
        }

        private string JsonFileNameZICANA
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "ZICANA.json"); }
        }

        public IEnumerable<Torro> GetZICANA()
        {
            using (var jsonFileReader = File.OpenText(JsonFileNameZICANA))
            {
                return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }
                    );
            }
        }

        private string JsonFileNameFLEX
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "FLEX.json"); }
        }

        public IEnumerable<Torro> GetFLEX()
        {
            using (var jsonFileReader = File.OpenText(JsonFileNameFLEX))
            {
                return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }
                    );
            }
        }

        private string JsonFileNameJEDNOUSNA
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "JEDNOUSNA.json"); }
        }

        public IEnumerable<Torro> GetJEDNOUSNA()
        {
            using (var jsonFileReader = File.OpenText(JsonFileNameJEDNOUSNA))
            {
                return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }
                    );
            }
        }

        private string JsonFileNameDVOUSNA
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "DVOUSNA.json"); }
        }

        public IEnumerable<Torro> GetDVOUSNA()
        {
            using (var jsonFileReader = File.OpenText(JsonFileNameDVOUSNA))
            {
                return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }
                    );
            }
        }

        private string JsonFileNamePRSTEN
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "PRSTEN.json"); }
        }

        public IEnumerable<Torro> GetPRSTEN()
        {
            using (var jsonFileReader = File.OpenText(JsonFileNamePRSTEN))
            {
                return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }
                    );
            }
        }



        private string JsonFileNameARS
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "ARS.json"); }
        }

        public IEnumerable<Torro> GetARS()
        {
            using (var jsonFileReader = File.OpenText(JsonFileNameARS))
            {
                return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }
                    );
            }
        }
    

    private string JsonFileNameRS
    {
        get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "RS.json"); }
    }

    public IEnumerable<Torro> GetRS()
    {
        using (var jsonFileReader = File.OpenText(JsonFileNameRS))
        {
            return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }
                );
        }
}
private string JsonFileNameBRS
{
    get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "BRS.json"); }
}

public IEnumerable<Torro> GetBRS()
{
    using (var jsonFileReader = File.OpenText(JsonFileNameBRS))
    {
        return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
            new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            }
            );
    }

    }

     private string JsonFileNameFGR
{
    get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "FGR.json"); }
}

public IEnumerable<Torro> GetFGR()
{
    using (var jsonFileReader = File.OpenText(JsonFileNameFGR))
    {
        return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
            new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            }
            );
    }
}
    

     private string JsonFileNameV
{
    get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "V.json"); }
}

public IEnumerable<Torro> GetV()
{
    using (var jsonFileReader = File.OpenText(JsonFileNameV))
    {
        return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
            new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            }
            );
    }
    }

     private string JsonFileNameTRAKE
{
    get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "TRAKE.json"); }
}

public IEnumerable<Torro> GetTRAKE()
{
    using (var jsonFileReader = File.OpenText(JsonFileNameTRAKE))
    {
        return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
            new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            }
            );
    }
    }

     private string JsonFileNameKOPCE
{
    get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "KOPCE.json"); }
}

public IEnumerable<Torro> GetKOPCE()
{
    using (var jsonFileReader = File.OpenText(JsonFileNameKOPCE))
    {
        return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
            new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            }
            );
    }
    }


    private string JsonFileNameJEDNODJELNA
    {
        get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "JEDNODJELNA.json"); }
    }

    public IEnumerable<Torro> GetJEDNODJELNA()
    {
        using (var jsonFileReader = File.OpenText(JsonFileNameJEDNODJELNA))
        {
            return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }
                );
        }
    }

    private string JsonFileNameDVODJELNA
    {
        get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "DVODJELNA.json"); }
    }

    public IEnumerable<Torro> GetDVODJELNA()
    {
        using (var jsonFileReader = File.OpenText(JsonFileNameDVODJELNA))
        {
            return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }
                );
        }
    }


    private string JsonFileNameGUMA
    {
        get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "GUMA.json"); }
    }

    public IEnumerable<Torro> GetGUMA()
    {
        using (var jsonFileReader = File.OpenText(JsonFileNameGUMA))
        {
            return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }
                );
        }
    }


    private string JsonFileNameSERIJEABC
    {
        get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "SERIJEABC.json"); }
    }

    public IEnumerable<Torro> GetSERIJEABC()
    {
        using (var jsonFileReader = File.OpenText(JsonFileNameSERIJEABC))
        {
            return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }
                );
        }
    }

    private string JsonFileNameKLIZNI
    {
        get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "KLIZNI.json"); }
    }

    public IEnumerable<Torro> GetKLIZNI()
    {
        using (var jsonFileReader = File.OpenText(JsonFileNameKLIZNI))
        {
            return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }
                );
        }
    }

    private string JsonFileNameSTREMEN
    {
        get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "STREMEN.json"); }
    }

    public IEnumerable<Torro> GetSTREMEN()
    {
        using (var jsonFileReader = File.OpenText(JsonFileNameSTREMEN))
        {
            return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }
                );
        }
    }

    private string JsonFileNameRSGU
    {
        get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "RSGU.json"); }
    }

    public IEnumerable<Torro> GetRSGU()
    {
        using (var jsonFileReader = File.OpenText(JsonFileNameRSGU))
        {
            return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }
                );
        }
    }

    private string JsonFileNameHMK
    {
        get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "HMK.json"); }
    }

    public IEnumerable<Torro> GetHMK()
    {
        using (var jsonFileReader = File.OpenText(JsonFileNameHMK))
        {
            return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }
                );
        }
    }

    private string JsonFileNameBS
    {
        get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "BS.json"); }
    }

    public IEnumerable<Torro> GetBS()
    {
        using (var jsonFileReader = File.OpenText(JsonFileNameBS))
        {
            return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }
                );
        }
    }

    private string JsonFileNameNORMETTA
    {
        get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "NORMETTA.json"); }
    }

    public IEnumerable<Torro> GetNORMETTA()
    {
        using (var jsonFileReader = File.OpenText(JsonFileNameNORMETTA))
        {
            return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }
                );
        }
    }

    private string JsonFileNameCABLETIES
    {
        get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "CABLETIES.json"); }
    }

    public IEnumerable<Torro> GetCABLETIES()
    {
        using (var jsonFileReader = File.OpenText(JsonFileNameCABLETIES))
        {
            return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }
                );
        }
    }


    private string JsonFileNameSV
    {
        get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "SV.json"); }
    }

    public IEnumerable<Torro> GetSV()
    {
        using (var jsonFileReader = File.OpenText(JsonFileNameSV))
        {
            return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }
                );
        }
    }

    private string JsonFileNameTLACNE
    {
        get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "TLACNE.json"); }
    }

    public IEnumerable<Torro> GetTLACNE()
    {
        using (var jsonFileReader = File.OpenText(JsonFileNameTLACNE))
        {
            return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }
                );
        }
    }


        private string JsonFileNameCETKE
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "indCETKE.json"); }
        }

        public IEnumerable<Torro> GetCETKE()
        {
            using (var jsonFileReader = File.OpenText(JsonFileNameCETKE))
            {
                return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }
                    );
            }
        }


        private string JsonFileNamePOVRSINSKE
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "POVRSINSKE.json"); }
        }

        public IEnumerable<Torro> GetPOVRSINSKE()
        {
            using (var jsonFileReader = File.OpenText(JsonFileNamePOVRSINSKE))
            {
                return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }
                    );
            }
        }

        private string JsonFileNameUGRADBENE
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "UGRADBENE.json"); }
        }

        public IEnumerable<Torro> GetUGRADBENE()
        {
            using (var jsonFileReader = File.OpenText(JsonFileNameUGRADBENE))
            {
                return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }
                    );
            }
        }

        private string JsonFileNameREFLEKTORI
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "REFLEKTORI.json"); }
        }

        public IEnumerable<Torro> GetREFLEKTORI()
        {
            using (var jsonFileReader = File.OpenText(JsonFileNameREFLEKTORI))
            {
                return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }
                    );
            }
        }

        private string JsonFileNameUSKE
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "USKE.json"); }
        }

        public IEnumerable<Torro> GetUSKE()
        {
            using (var jsonFileReader = File.OpenText(JsonFileNameUSKE))
            {
                return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }
                    );
            }
        }


        private string JsonFileNameCIJEVNESVJETILJKE
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "CIJEVNESVJETILJKE.json"); }
        }

        public IEnumerable<Torro> GetCIJEVNESVJETILJKE()
        {
            using (var jsonFileReader = File.OpenText(JsonFileNameCIJEVNESVJETILJKE))
            {
                return JsonSerializer.Deserialize<Torro[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }
                    );
            }
        }



    }
}