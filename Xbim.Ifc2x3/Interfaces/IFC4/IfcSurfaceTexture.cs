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
	public partial class @IfcSurfaceTexture : IIfcSurfaceTexture
	{
		Ifc4.MeasureResource.IfcBoolean IIfcSurfaceTexture.RepeatS 
		{ 
			get
			{
				//## Handle return of RepeatS for which no match was found
			    return new Ifc4.MeasureResource.IfcBoolean(RepeatS);
			    //##
			} 
		}
		Ifc4.MeasureResource.IfcBoolean IIfcSurfaceTexture.RepeatT 
		{ 
			get
			{
				//## Handle return of RepeatT for which no match was found
                return new Ifc4.MeasureResource.IfcBoolean(RepeatT);
				//##
			} 
		}
		Ifc4.MeasureResource.IfcIdentifier? IIfcSurfaceTexture.Mode 
		{ 
			get
			{
				//## Handle return of Mode for which no match was found
                return null;
				//##
			} 
		}
		IIfcCartesianTransformationOperator2D IIfcSurfaceTexture.TextureTransform 
		{ 
			get
			{
				return TextureTransform;
			} 
		}
		IEnumerable<Xbim.Ifc4.MeasureResource.IfcIdentifier> IIfcSurfaceTexture.Parameter 
		{ 
			get
			{
				//## Handle return of Parameter for which no match was found
				return null;
				//##
			} 
		}
		IEnumerable<IIfcTextureCoordinate> IIfcSurfaceTexture.IsMappedBy 
		{ 
			get
			{
				return Model.Instances.Where<IIfcTextureCoordinate>(e => e.Maps != null &&  e.Maps.Contains(this));
			} 
		}
		IEnumerable<IIfcSurfaceStyleWithTextures> IIfcSurfaceTexture.UsedInStyles 
		{ 
			get
			{
				return Model.Instances.Where<IIfcSurfaceStyleWithTextures>(e => e.Textures != null &&  e.Textures.Contains(this));
			} 
		}
	//## Custom code
	//##
	}
}