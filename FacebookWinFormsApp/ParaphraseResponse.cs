using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class ParaphraseResponse
    {
        public string Id { get; set; }
        public List<Suggestion> Suggestions { get; set; }
    }
}
