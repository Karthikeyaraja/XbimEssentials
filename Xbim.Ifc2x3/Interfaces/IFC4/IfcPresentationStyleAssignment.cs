// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	public partial class @IfcPresentationStyleAssignment : IIfcPresentationStyleAssignment
	{
		IEnumerable<IIfcPresentationStyleSelect> IIfcPresentationStyleAssignment.Styles 
		{ 
			get
			{
				foreach (var member in Styles)
				{
					var ifccurvestyle = member as IfcCurveStyle;
					if (ifccurvestyle != null) 
						yield return ifccurvestyle;
					var ifcsymbolstyle = member as IfcSymbolStyle;
				    if (ifcsymbolstyle != null)
				        //## Handle entity IfcSymbolStyle which is not a part of the target select interface IIfcPresentationStyleSelect in property Styles
				    {
				      /*  var colour = ifcsymbolstyle.StyleOfSymbol as IIfcColourRgb;
                        if(colour!=null)
                            return colour;*/
				        yield return new Ifc4.PresentationAppearanceResource.IfcNullStyle();
				    }
						//##
					var ifcfillareastyle = member as IfcFillAreaStyle;
					if (ifcfillareastyle != null) 
						yield return ifcfillareastyle;
					var ifctextstyle = member as IfcTextStyle;
					if (ifctextstyle != null) 
						yield return ifctextstyle;
					var ifcsurfacestyle = member as IfcSurfaceStyle;
					if (ifcsurfacestyle != null) 
						yield return ifcsurfacestyle;
					if (member is IfcNullStyle) 
						//## Handle defined type IfcNullStyle which is not a part of the target select interface IEnumerable<IIfcPresentationStyleSelect> in property Styles
                        yield return new Ifc4.PresentationAppearanceResource.IfcNullStyle();
						//##
				}
			} 
		}
	//## Custom code
	//##
	}
}