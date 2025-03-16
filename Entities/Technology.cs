using System;

namespace Entities
{
    public class Technology
    {
        // 1. Entities (Varlıklar) Katmanı
        
            public int Id { get; set; }
            public string Name { get; set; }

            // Hata buradan kaynaklanıyor olabilir!
            public int ProgrammingLanguageId { get; set; } // Programlama diliyle ilişkilendirme için ID
        
    }
}
