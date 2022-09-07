﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using YumCity_Migrations.HelperClasses;
using YumCity_Migrations.FactoryClasses;
using YumCity_Migrations.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace YumCity_Migrations.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'Instruction'.<br/><br/></summary>
	[Serializable]
	public partial class InstructionEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
	
	{
		private RecipeEntity _recipe;
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END

		private static InstructionEntityStaticMetaData _staticMetaData = new InstructionEntityStaticMetaData();
		private static InstructionRelations _relationsFactory = new InstructionRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Recipe</summary>
			public static readonly string Recipe = "Recipe";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class InstructionEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public InstructionEntityStaticMetaData()
			{
				SetEntityCoreInfo("InstructionEntity", InheritanceHierarchyType.None, false, (int)YumCity_Migrations.EntityType.InstructionEntity, typeof(InstructionEntity), typeof(InstructionEntityFactory), false);
				AddNavigatorMetaData<InstructionEntity, RecipeEntity>("Recipe", "Instructions", (a, b) => a._recipe = b, a => a._recipe, (a, b) => a.Recipe = b, YumCity_Migrations.RelationClasses.StaticInstructionRelations.RecipeEntityUsingRecipeIdStatic, ()=>new InstructionRelations().RecipeEntityUsingRecipeId, null, new int[] { (int)InstructionFieldIndex.RecipeId }, null, true, (int)YumCity_Migrations.EntityType.RecipeEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static InstructionEntity()
		{
		}

		/// <summary> CTor</summary>
		public InstructionEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public InstructionEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this InstructionEntity</param>
		public InstructionEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Instruction which data should be fetched into this Instruction object</param>
		public InstructionEntity(System.Guid id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Instruction which data should be fetched into this Instruction object</param>
		/// <param name="validator">The custom validator object for this InstructionEntity</param>
		public InstructionEntity(System.Guid id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected InstructionEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Recipe' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecipe() { return CreateRelationInfoForNavigator("Recipe"); }
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this InstructionEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END


			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static InstructionRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Recipe' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRecipe { get { return _staticMetaData.GetPrefetchPathElement("Recipe", CommonEntityBase.CreateEntityCollection<RecipeEntity>()); } }

		/// <summary>The Data property of the Entity Instruction<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Instruction"."Data".<br/>Table field type characteristics (type, precision, scale, length): Text, 0, 0, 1073741824.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Data
		{
			get { return (System.String)GetValue((int)InstructionFieldIndex.Data, true); }
			set	{ SetValue((int)InstructionFieldIndex.Data, value); }
		}

		/// <summary>The Id property of the Entity Instruction<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Instruction"."Id".<br/>Table field type characteristics (type, precision, scale, length): Uuid, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Guid Id
		{
			get { return (System.Guid)GetValue((int)InstructionFieldIndex.Id, true); }
			set	{ SetValue((int)InstructionFieldIndex.Id, value); }
		}

		/// <summary>The RecipeId property of the Entity Instruction<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Instruction"."RecipeId".<br/>Table field type characteristics (type, precision, scale, length): Uuid, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid RecipeId
		{
			get { return (System.Guid)GetValue((int)InstructionFieldIndex.RecipeId, true); }
			set	{ SetValue((int)InstructionFieldIndex.RecipeId, value); }
		}

		/// <summary>Gets / sets related entity of type 'RecipeEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual RecipeEntity Recipe
		{
			get { return _recipe; }
			set { SetSingleRelatedEntityNavigator(value, "Recipe"); }
		}
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END


	}
}

namespace YumCity_Migrations
{
	public enum InstructionFieldIndex
	{
		///<summary>Data. </summary>
		Data,
		///<summary>Id. </summary>
		Id,
		///<summary>RecipeId. </summary>
		RecipeId,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace YumCity_Migrations.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Instruction. </summary>
	public partial class InstructionRelations: RelationFactory
	{

		/// <summary>Returns a new IEntityRelation object, between InstructionEntity and RecipeEntity over the m:1 relation they have, using the relation between the fields: Instruction.RecipeId - Recipe.Id</summary>
		public virtual IEntityRelation RecipeEntityUsingRecipeId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Recipe", false, new[] { RecipeFields.Id, InstructionFields.RecipeId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticInstructionRelations
	{
		internal static readonly IEntityRelation RecipeEntityUsingRecipeIdStatic = new InstructionRelations().RecipeEntityUsingRecipeId;

		/// <summary>CTor</summary>
		static StaticInstructionRelations() { }
	}
}