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
using Xbim.Ifc4.MeasureResource;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.GeometryResource
{
	public partial class @IfcCartesianTransformationOperator : IIfcCartesianTransformationOperator
	{
		IIfcDirection IIfcCartesianTransformationOperator.Axis1 
		{ 
			get
			{
				return Axis1;
			} 
		}
		IIfcDirection IIfcCartesianTransformationOperator.Axis2 
		{ 
			get
			{
				return Axis2;
			} 
		}
		IIfcCartesianPoint IIfcCartesianTransformationOperator.LocalOrigin 
		{ 
			get
			{
				return LocalOrigin;
			} 
		}
		Ifc4.MeasureResource.IfcReal? IIfcCartesianTransformationOperator.Scale 
		{ 
			get
			{
				//## Handle return of Scale for which no match was found
                return Scale.HasValue ? new Ifc4.MeasureResource.IfcReal(Scale.Value) : (Ifc4.MeasureResource.IfcReal?)null;
                //##
			} 
		}
		Ifc4.MeasureResource.IfcReal IIfcCartesianTransformationOperator.Scl 
		{
			get 
			{
				return new Ifc4.MeasureResource.IfcReal(Scl);
			}
		}

		Ifc4.GeometryResource.IfcDimensionCount IIfcCartesianTransformationOperator.Dim 
		{
			get 
			{
				return new Ifc4.GeometryResource.IfcDimensionCount(Dim);
			}
		}

	//## Custom code
	//##
	}
}