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
namespace Xbim.Ifc2x3.ProfilePropertyResource
{
	public partial class @IfcProfileProperties : IIfcProfileProperties
	{
		IIfcProfileDef IIfcProfileProperties.ProfileDefinition 
		{ 
			get
			{
				return ProfileDefinition;
			} 
			set
			{
				ProfileDefinition = value as ProfileResource.IfcProfileDef;
				
			}
		}
		Ifc4.MeasureResource.IfcIdentifier? IIfcExtendedProperties.Name 
		{ 
			get
			{
				if (!ProfileName.HasValue) return null;
				return new Ifc4.MeasureResource.IfcIdentifier(ProfileName.Value);
			} 
			set
			{
				ProfileName = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}

		private  Ifc4.MeasureResource.IfcText? _description;

		Ifc4.MeasureResource.IfcText? IIfcExtendedProperties.Description 
		{ 
			get
			{
				return _description;
			} 
			set
			{
				SetValue(v => _description = v, _description, value, "Description", byte.MaxValue);
				
			}
		}
		IEnumerable<IIfcProperty> IIfcExtendedProperties.Properties 
		{ 
			get
			{
				//## Handle return of Properties for which no match was found
			    return _properties ?? (_properties = new ItemSet<IIfcProperty>(this, 0, byte.MaxValue));
			    //##
			} 
		}
		IEnumerable<IIfcExternalReferenceRelationship> IIfcPropertyAbstraction.HasExternalReferences 
		{ 
			get
			{
				return Model.Instances.Where<IIfcExternalReferenceRelationship>(e => e.RelatedResourceObjects != null &&  e.RelatedResourceObjects.Contains(this), "RelatedResourceObjects", this);
			} 
		}
	//## Custom code
	    private IItemSet<IIfcProperty> _properties;
	    //##
	}
}