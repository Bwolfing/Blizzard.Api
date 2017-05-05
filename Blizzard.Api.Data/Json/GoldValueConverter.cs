using System;
using Blizzard.Api.Data.WoW;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Blizzard.Api.Data.Json
{
    public class GoldValueConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (!CanConvert(objectType))
            {
                throw new ArgumentException($"Cannot convert to type {objectType}");
            }

            GoldValue g = new GoldValue();

            double valueInCopper = 0;

            if (double.TryParse(reader.Value.ToString(), out valueInCopper))
            {
                g.ValueInCopper = valueInCopper;
            }

            return g;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(GoldValue);
        }
    }
}