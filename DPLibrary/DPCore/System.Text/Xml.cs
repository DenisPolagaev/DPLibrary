using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DPLibrary.DPCore.System.Text
{
    public static class Xml<T>
    {
        public static string Serialize(T obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException($"{nameof(obj)} - is null");
            }

            var xmlSerializer = new XmlSerializer(typeof(T));
            using var sw = new StringWriter();
            using var writer = XmlWriter.Create(sw);
            xmlSerializer.Serialize(writer, obj);
            return sw.ToString();
        }

        public static async Task SerializeAsync(T obj, FileInfo file, bool append = false)
        {
            if (obj == null)
            {
                throw new ArgumentNullException($"{nameof(obj)} - is null");
            }

            if (file == null)
            {
                throw new ArgumentNullException($"{nameof(file)} - is null");
            }

            using var fs = new StreamWriter(file.FullName, append);
            await fs.WriteAsync(Serialize(obj));
        }

        public static T Deserialize(string xml)
        {
            if (string.IsNullOrWhiteSpace(xml) || string.IsNullOrEmpty(xml))
            {
                throw new ArgumentNullException($"{nameof(xml)} - is null");
            }

            var xmlSerializer = new XmlSerializer(typeof(T));
            using var reader = new StringReader(xml);
            var obj = xmlSerializer.Deserialize(reader);
            if (obj is T returnObject)
            {
                return returnObject;
            }
            throw new InvalidCastException($"{nameof(xml)} is not {typeof(T)}");
        }

        public static async Task<T> DeserializeAsync(FileInfo file, Encoding code = default)
        {
            if (file == null)
            {
                throw new ArgumentNullException($"{nameof(file)} - is null");
            }
            if (!file.Exists)
            {
                throw new IOException($"{nameof(file)} is not exist");
            }
            using var fs = new StreamReader(file.FullName, code ?? Encoding.UTF8);
            var xml = await fs.ReadToEndAsync();
            return Deserialize(xml);
        }
    }
}
