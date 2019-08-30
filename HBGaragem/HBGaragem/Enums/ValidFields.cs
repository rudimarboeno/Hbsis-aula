using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace HBGaragem.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ValidFields
    {
        ValidaNome,
        ValidaEmail,
        ValidaPlaca,
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Status
    {
        [EnumMember(Value = "Vigente")]
        VIGENTE = 1,

        [EnumMember(Value = "Em Aprovação")]
        EM_APROVACAO = 2,

        [EnumMember(Value = "Fila de Espera")]
        FILA_DE_ESPERA = 3
    }

   

}