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
using Xbim.Common;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.ProductExtension
{
	public partial class @IfcRelSpaceBoundary : IIfcRelSpaceBoundary
	{

		private  IIfcSpaceBoundarySelect _relatingSpace4;

		IIfcSpaceBoundarySelect IIfcRelSpaceBoundary.RelatingSpace 
		{ 
			get
			{
				return  _relatingSpace4 ?? RelatingSpace;
			} 
			set
			{
				if (value == null)
				{
					RelatingSpace = null;
					if (_relatingSpace4 != null)
						SetValue(v => _relatingSpace4 = v, _relatingSpace4, null, "RelatingSpace", byte.MaxValue);
					return;
				}
				
				var val = value as IfcSpace;
				if (val != null)
				{
					RelatingSpace = val;
					if (_relatingSpace4 != null)
						SetValue(v => _relatingSpace4 = v, _relatingSpace4, null, "RelatingSpace", byte.MaxValue);
					return;
				} 

				if(RelatingSpace != null)
					RelatingSpace = null;
				SetValue(v => _relatingSpace4 = v, _relatingSpace4, value, "RelatingSpace", byte.MaxValue);
				
			}
		}
		IIfcElement IIfcRelSpaceBoundary.RelatedBuildingElement 
		{ 
			get
			{
				return RelatedBuildingElement;
			} 
			set
			{
				RelatedBuildingElement = value as IfcElement;
				
			}
		}
		IIfcConnectionGeometry IIfcRelSpaceBoundary.ConnectionGeometry 
		{ 
			get
			{
				return ConnectionGeometry;
			} 
			set
			{
				ConnectionGeometry = value as GeometricConstraintResource.IfcConnectionGeometry;
				
			}
		}
		Ifc4.Interfaces.IfcPhysicalOrVirtualEnum IIfcRelSpaceBoundary.PhysicalOrVirtualBoundary 
		{ 
			get
			{
				//## Custom code to handle enumeration of PhysicalOrVirtualBoundary
				//##
				switch (PhysicalOrVirtualBoundary)
				{
					case IfcPhysicalOrVirtualEnum.PHYSICAL:
						return Ifc4.Interfaces.IfcPhysicalOrVirtualEnum.PHYSICAL;
					
					case IfcPhysicalOrVirtualEnum.VIRTUAL:
						return Ifc4.Interfaces.IfcPhysicalOrVirtualEnum.VIRTUAL;
					
					case IfcPhysicalOrVirtualEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcPhysicalOrVirtualEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of PhysicalOrVirtualBoundary
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcPhysicalOrVirtualEnum.PHYSICAL:
						PhysicalOrVirtualBoundary = IfcPhysicalOrVirtualEnum.PHYSICAL;
						return;
					
					case Ifc4.Interfaces.IfcPhysicalOrVirtualEnum.VIRTUAL:
						PhysicalOrVirtualBoundary = IfcPhysicalOrVirtualEnum.VIRTUAL;
						return;
					
					case Ifc4.Interfaces.IfcPhysicalOrVirtualEnum.NOTDEFINED:
						PhysicalOrVirtualBoundary = IfcPhysicalOrVirtualEnum.NOTDEFINED;
						return;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
		Ifc4.Interfaces.IfcInternalOrExternalEnum IIfcRelSpaceBoundary.InternalOrExternalBoundary 
		{ 
			get
			{
				//## Custom code to handle enumeration of InternalOrExternalBoundary
                if(Description.HasValue)
                    switch (Description.Value)
                    {
                        case "EXTERNAL_EARTH":
                        case "EXTERNAL_WATER":
                        case "EXTERNAL_FIRE":
                            return
                                (Ifc4.Interfaces.IfcInternalOrExternalEnum)
                                    System.Enum.Parse(typeof (Ifc4.Interfaces.IfcInternalOrExternalEnum),
                                        Description.Value);
                    }

				//##
				switch (InternalOrExternalBoundary)
				{
					case IfcInternalOrExternalEnum.INTERNAL:
						return Ifc4.Interfaces.IfcInternalOrExternalEnum.INTERNAL;
					
					case IfcInternalOrExternalEnum.EXTERNAL:
						return Ifc4.Interfaces.IfcInternalOrExternalEnum.EXTERNAL;
					
					case IfcInternalOrExternalEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcInternalOrExternalEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of InternalOrExternalBoundary
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcInternalOrExternalEnum.INTERNAL:
						InternalOrExternalBoundary = IfcInternalOrExternalEnum.INTERNAL;
						return;
					
					case Ifc4.Interfaces.IfcInternalOrExternalEnum.EXTERNAL:
						InternalOrExternalBoundary = IfcInternalOrExternalEnum.EXTERNAL;
						return;
					
					case Ifc4.Interfaces.IfcInternalOrExternalEnum.EXTERNAL_EARTH:
						//## Handle setting of EXTERNAL_EARTH member from IfcInternalOrExternalEnum in property InternalOrExternalBoundary
				        Description = value.ToString();
				        return;
						//##
										
					case Ifc4.Interfaces.IfcInternalOrExternalEnum.EXTERNAL_WATER:
						//## Handle setting of EXTERNAL_WATER member from IfcInternalOrExternalEnum in property InternalOrExternalBoundary
						Description = value.ToString();
				        return;
						//##
										
					case Ifc4.Interfaces.IfcInternalOrExternalEnum.EXTERNAL_FIRE:
						//## Handle setting of EXTERNAL_FIRE member from IfcInternalOrExternalEnum in property InternalOrExternalBoundary
						Description = value.ToString();
				        return;
						//##
										
					case Ifc4.Interfaces.IfcInternalOrExternalEnum.NOTDEFINED:
						InternalOrExternalBoundary = IfcInternalOrExternalEnum.NOTDEFINED;
						return;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
	//## Custom code
	//##
	}
}