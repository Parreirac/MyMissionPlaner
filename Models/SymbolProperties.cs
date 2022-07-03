// PRA
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Collections.Generic;
using System.Windows.Media;

namespace MilitaryPlanner.Helpers
{

    ///           <member name = "T:Esri.ArcGISRuntime.Symbology.Specialized.SymbolProperties" >
    ///            < summary >
    ///  Represents individual symbols within the<see cref="T:Esri.ArcGISRuntime.Symbology.Specialized.SymbolDictionary"/>
    ///          </summary>
    ///      </member>

    ///        <member name = "M:Esri.ArcGISRuntime.Symbology.Specialized.SymbolProperties.Equals(System.Object)" >
    ///            < summary >
    ///    Determines whether the specified<see cref="T:System.Object"/> is equal to this instance.
    ///            </summary>
    ///            <param name = "obj" > The < see cref= "T:System.Object" /> to compare with this instance.</param>
    ///           <returns>
    ///             <c>true</c> if the specified <see cref = "T:System.Object" /> is equal to this instance; otherwise, <c>false</c>.
    ///           </returns>
    ///       </member>
    ///        <member name = "M:Esri.ArcGISRuntime.Symbology.Specialized.SymbolProperties.GetHashCode" >
    ///            < summary >
    ///   Returns a hash code for this symbol instance.
    ///           </summary>
    ///           <returns>
    ///   A<see cref="T:System.Int32"/> representing the hash code for this symbol instance. 
    ///           </returns>
    ///       </member>
    ///    

    // classe de base pour stocker les propriétés des symboles militaire
    public class SymbolProperties
    {

        // Résumé :
        //     Gets the key (unique identifier) associated to a symbol.
        public string Key { get; }

        public IReadOnlyList<string> Tags { get; set; }

        // Résumé :
        //     Gets the category associated to a symbol. a la base :3 point, 4 line, 5 polyline, mais a basculé dans symbolClass
        public string Category
        { get; }

        // Résumé :
        //     Gets the class associated to a symbol.
        public string SymbolClass { get; }

        ///  <member name = "P:Esri.ArcGISRuntime.Symbology.Specialized.SymbolProperties.Name" >
        ///           < summary >  Gets the name of the symbol.           </summary>
        ///           <value>
        ///   A<see cref="T:System.String"/> representing the symbol name.
        ///            </value>
        ///        </member>
        ///     
        // The name of the symbol as it appears in the mobile style.
        public string Name { get; /* private*/  set; }

        ///        <member name = "P:Esri.ArcGISRuntime.Symbology.Specialized.SymbolProperties.Keywords" >
        ///           < summary >
        ///   Gets or sets the keywords/Tags associated with this symbol.
        ///           </summary>
        ///           <value>
        ///   A<see cref="T:System.Collections.Generic.IEnumerable`1"/> of keywords.
        ///          </value>
        ///      </member>
        ///      

        //    private string 
        public string SymbolID
        {
            get; set;
        }

        //   public Symbol S
        public string Keywords
        {
            get
            {
                if (Tags == null)
                    return null;  // TODO PRA mettre un assert ?
                return string.Join(", ", Tags); // ; plutot que , ?
            }
        }

        public object GraphicObject { get; set; }


        // TODO PRA on part du principe qu'il n'y a qu'1 key (tag?) TODO a tester
        public SymbolProperties(string name = "", ImageSource source = null, string key = "", string category = "", string symbolClass = "", IReadOnlyList<string> tags = null)
        {
            Tags = tags;
            if (Tags == null)
                Tags = new List<string>();
            SymbolClass = symbolClass;
            Category = category;
            Name = name;
            Image = source;
            Key = key;

            if (Image == null && false)  // TODO PRA a mettre en static ?
            {
                // Create an empty placeholder image to represent "no symbol" for each category.
                Image = System.Windows.Media.Imaging.BitmapSource.Create
                    (2, 2, Constants._imageSize, Constants._imageSize,// 96, 96,
                     System.Windows.Media.PixelFormats.Indexed1,
                     new System.Windows.Media.Imaging.BitmapPalette(new List<System.Windows.Media.Color> { System.Windows.Media.Colors.Transparent }),
                     new byte[4],
                     1);
            }

            RetriveSIDC();
        }



        ///      <member name = "M:Esri.ArcGISRuntime.Symbology.Specialized.SymbolProperties.GetImage(System.Int32,System.Int32)" >
        ///           < summary > Gets the image for the symbol </summary>
        ///       <param name = "width" > A < see cref= "T:System.Int32" /> representing the image width.</param>
        ///        <param name = "height" > A < see cref= "T:System.Int32" /> representing the image height.</param>
        ///        <returns></returns>
        ///       </member>

        public ImageSource Image { get; set; }

        // voir SDC MIL2525C p44 
        public static System.Drawing.Color MilStandardColor_unfilled_symbols(string symbolCode)         
        {
            System.Drawing.Color color;

            switch (symbolCode[1])
                {

                    case 'F':// Friend
                    case 'A':// Assumed Friend 
                    case 'M':// EXERCISE ASSUMED FRIEND
                    case 'D':// EXERCISE FRIEND
                        color = System.Drawing.Color.FromArgb(0, 255, 0);// Neon Green
                        break;
                    case 'N':// Neutral
                    case 'L':// EXERCISE NEUTRAL
                        color = System.Drawing.Color.FromArgb(0, 255, 0);// Neon Green
                        break;
                    case 'H'://Hostile
                    case 'S'://Suspect
                    case 'J'://Joker
                    case 'K'://Faker
                        color = System.Drawing.Color.FromArgb( 255,0, 0);// Red
                        break;
                    case 'C'://Civilian(Optional)
                        color = System.Drawing.Color.FromArgb(255, 0, 255);// Magenta
                        break;                    
                    case 'P': // Pending     
                    case 'U': // Unknown
                    case 'G': // EXERCISE PENDING
                    case 'W': // EXERCISE UNKNOWN
                    case '*':
                    default:
                        color = System.Drawing.Color.FromArgb(255, 255, 0);// Yellow
                        break;
                       
                } 
                return color;


        }

        // SDC MIL2525C p57
        //  CODING SCHEME S - WARFIGHTING E, 
        // ORDER OF BATTLE (1)   (POSITION 15)  A : AIR OB, E : ELECTRONIC OB, C : CIVILIAN OB, G : GROUND OB, N : MARITIME OB, S : STRATEGIC FORCE
        // COUNTRY CODE(2) (POSITION 13, 14)

        public bool RetriveSIDC()
        {
            if (SymbolID != null && SymbolID.Length != 0)
                return true;
            // CODING SCHEME S - WARFIGHTING
            // STANDARD IDENTITY/EXERCISE AMPLIFYING DESCRIPTOR
            char[] SP2 = { 'P', 'U', 'A', 'F', 'N', 'S', 'H', 'G', 'W', 'M', 'D', 'L', 'J', 'K', '*' };
            // BATTLE DIMENSION
            char[] SP3 = { 'P', 'A', 'G', 'S', 'U', 'F', 'X', 'Z' };
            //STATUS/OPERATIONAL CONDITION
            char[] SP4 = { 'A', 'P', 'C', 'D', 'X', 'F' };

            // CODING SCHEME E
            // EMERGENCY MANAGEMENT SYMBOLS NATURAL EVENTS
            // Utilisation egalement pour la protection civile

            // CODING SCHEME G G - TACTICAL GRAPHICS  p 305

            // CODING SCHEME O 
            // Operation de police
            char[] OP3 = { 'P', 'G', 'O', 'V', 'I', 'L' };

            string symboleCode = null;
            foreach (string tag in Tags)
            {
                if (tag.StartsWith("NEW_AT_", true, null)) // on cherche sans case
                    symboleCode = tag;

                if (symboleCode != null)
                    break;

                if (tag[0] == 'S')
                {

                    bool bp2 = false;
                    foreach (char c in SP2)
                    { if (tag[1] == c) { bp2 = true; break; } }

                    if (bp2)
                    {
                        bool bp3 = false;
                        foreach (char c in SP3)
                        { if (tag[2] == c) { bp3 = true; break; } }

                        if (bp3)
                        {
                            bool bp4 = false;
                            foreach (char c in SP4)
                            { if (tag[3] == c) { bp4 = true; break; } }

                            if (bp4)
                                symboleCode = tag;
                        }
                    }
                }

                if (tag[0] == 'E')
                {
                    if (tag.StartsWith("E*NP", true, null)|| tag.StartsWith("E*OP", true, null)|| tag.StartsWith("EFOP", true, null)) // on cherche sans case
                        symboleCode = tag;
                    if ( tag.StartsWith("E*FP", true, null) || tag.StartsWith("EUFP", true, null) || tag.StartsWith("EFFP", true, null)) // on cherche sans case
                        symboleCode = tag;
                    if (tag.StartsWith("ENFP", true, null)|| tag.StartsWith("EHFP", true, null) || tag.StartsWith("EUOP", true, null)) // on cherche sans case
                        symboleCode = tag;
                    if (tag.StartsWith("ENOP", true, null)|| tag.StartsWith("EHOP", true, null) || tag.StartsWith("E*IP", true, null)) // on cherche sans case
                        symboleCode = tag;


                }

                if (tag[0] == 'O' && tag[3] == 'P')
                {
                    if (tag[1] == '*')
                    foreach (char c in OP3)
                    { if (tag[3] == c) { symboleCode = tag; break; } }

                    if (tag.StartsWith("OUOP", true, null) || tag.StartsWith("OFOP", true, null) || tag.StartsWith("ONOP", true, null) || tag.StartsWith("OHOP", true, null))
                        symboleCode = tag;
                }


                if (tag[0] == 'G')
                {
                    if (tag.StartsWith("G*GP", true, null)|| tag.StartsWith("G*OP", true, null) || tag.StartsWith("G*FP", true, null) || tag.StartsWith("G*MP", true, null) || tag.StartsWith("G*SP", true, null))// || tag.StartsWith("E*OP", true, null) || tag.StartsWith("EFOP", true, null)) // on cherche sans case
                        symboleCode = tag;
                    if (tag.StartsWith("G*TP", true, null) )//|| tag.StartsWith("G*OP", true, null) || tag.StartsWith("G*FP", true, null) || tag.StartsWith("G*MP", true, null) || tag.StartsWith("G*SP", true, null))// || tag.StartsWith("E*OP", true, null) || tag.StartsWith("EFOP", true, null)) // on cherche sans case
                        symboleCode = tag;

                }
                if (tag[0] == 'W')
                {
                    if (tag.StartsWith("WAS-", true, null) || tag.StartsWith("WOS-", true, null) || tag.StartsWith("WO-D", true, null) || tag.StartsWith("WA-D", true, null)) // on cherche sans case
                        symboleCode = tag;
             //       if (tag.StartsWith("G*TP", true, null))//|| tag.StartsWith("G*OP", true, null) || tag.StartsWith("G*FP", true, null) || tag.StartsWith("G*MP", true, null) || tag.StartsWith("G*SP", true, null))// || tag.StartsWith("E*OP", true, null) || tag.StartsWith("EFOP", true, null)) // on cherche sans case
             //           symboleCode = tag;

                }

                if (tag[0] == 'I')
                {
                    if (tag.StartsWith("I*AP", true, null) || tag.StartsWith("I*GP", true, null)) // on cherche sans case
                        symboleCode = tag;
                    //       if (tag.StartsWith("G*TP", true, null))//|| tag.StartsWith("G*OP", true, null) || tag.StartsWith("G*FP", true, null) || tag.StartsWith("G*MP", true, null) || tag.StartsWith("G*SP", true, null))// || tag.StartsWith("E*OP", true, null) || tag.StartsWith("EFOP", true, null)) // on cherche sans case
                    //           symboleCode = tag;

                }

                if (tag[0] == 'M'&& tag[1] == 'O' && tag[2] == 'D')
                {
                 //   if (tag.StartsWith("I*AP", true, null) || tag.StartsWith("I*GP", true, null)) // on cherche sans case
                        symboleCode = tag;
                    //       if (tag.StartsWith("G*TP", true, null))//|| tag.StartsWith("G*OP", true, null) || tag.StartsWith("G*FP", true, null) || tag.StartsWith("G*MP", true, null) || tag.StartsWith("G*SP", true, null))// || tag.StartsWith("E*OP", true, null) || tag.StartsWith("EFOP", true, null)) // on cherche sans case
                    //           symboleCode = tag;

                }

            }
            if (symboleCode != null)
            {
                SymbolID = symboleCode;
         //       this.Values["SymbolID"] = symboleCode;
                return true;
            }

            SymbolID  = this.Keywords;
            //      this.Values["SymbolID"] = this.Keywords;
            return false;

        }





    }
}