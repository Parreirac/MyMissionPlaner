using Esri.ArcGISRuntime.Geometry;
using System.Diagnostics.CodeAnalysis;

namespace MyMissionPlaner.Helpers.MyHelpers
{

    //
    // Résumé :
    //     Represents a double-precision floating-point number.
    public readonly struct MyDouble
    {

        // Sur une base de TryParse qui ne lit pas Double.TryParse("1.1", out z);
        public static bool TryParse(string s, out double result)
        {
            if (System.Double.TryParse(s, out result)) return true;
            return System.Double.TryParse(s.Replace('.', ','), out result); // s.Replace('.',',')
        }
    }

/*
    public class MyEllipse : Esri.ArcGISRuntime.Geometry.Geometry
    {
          public MyEllipse(EllipticArcSegment source) : base()
          { }


        public override Envelope Extent =>
        {
         //  Esri.ArcGISRuntime.Geometry.EllipticArcSegment EllipticArcSegment sr;
         //   sr.
                return null;
        }//  throw new System.NotImplementedException();

        public override GeometryType GeometryType => GeometryType.Unknown - 1;// .//throw new System.NotImplementedException();

        public override bool HasZ =>  false; //throw new System.NotImplementedException();

        public override bool HasM =>  false;// throw new System.NotImplementedException();

        public override GeometryDimension Dimension => GeometryDimension.Curve;// throw new System.NotImplementedException();

        public override bool IsEmpty =>  false;//throw new System.NotImplementedException();

        internal override CoreGeometry CoreGeometry => throw new System.NotImplementedException();

        public override bool IsEqual([NotNullWhen(true)] Geometry other)
        {
            return false;// this.throw new System.NotImplementedException();
        }
    }
*/
}
