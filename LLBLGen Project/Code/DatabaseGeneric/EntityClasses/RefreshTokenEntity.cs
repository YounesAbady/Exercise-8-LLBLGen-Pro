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

	/// <summary>Entity class which represents the entity 'RefreshToken'.<br/><br/></summary>
	[Serializable]
	public partial class RefreshTokenEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
	
	{
		private EntityCollection<UserEntity> _users;
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END

		private static RefreshTokenEntityStaticMetaData _staticMetaData = new RefreshTokenEntityStaticMetaData();
		private static RefreshTokenRelations _relationsFactory = new RefreshTokenRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Users</summary>
			public static readonly string Users = "Users";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class RefreshTokenEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public RefreshTokenEntityStaticMetaData()
			{
				SetEntityCoreInfo("RefreshTokenEntity", InheritanceHierarchyType.None, false, (int)YumCity_Migrations.EntityType.RefreshTokenEntity, typeof(RefreshTokenEntity), typeof(RefreshTokenEntityFactory), false);
				AddNavigatorMetaData<RefreshTokenEntity, EntityCollection<UserEntity>>("Users", a => a._users, (a, b) => a._users = b, a => a.Users, () => new RefreshTokenRelations().UserEntityUsingRefreshTokenId, typeof(UserEntity), (int)YumCity_Migrations.EntityType.UserEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static RefreshTokenEntity()
		{
		}

		/// <summary> CTor</summary>
		public RefreshTokenEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public RefreshTokenEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this RefreshTokenEntity</param>
		public RefreshTokenEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for RefreshToken which data should be fetched into this RefreshToken object</param>
		public RefreshTokenEntity(System.Guid id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for RefreshToken which data should be fetched into this RefreshToken object</param>
		/// <param name="validator">The custom validator object for this RefreshTokenEntity</param>
		public RefreshTokenEntity(System.Guid id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected RefreshTokenEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'User' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUsers() { return CreateRelationInfoForNavigator("Users"); }
		
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
		/// <param name="validator">The validator object for this RefreshTokenEntity</param>
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
		public static RefreshTokenRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'User' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUsers { get { return _staticMetaData.GetPrefetchPathElement("Users", CommonEntityBase.CreateEntityCollection<UserEntity>()); } }

		/// <summary>The Id property of the Entity RefreshToken<br/><br/></summary>
		/// <remarks>Mapped on  table field: "refresh_token"."id".<br/>Table field type characteristics (type, precision, scale, length): Uuid, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Guid Id
		{
			get { return (System.Guid)GetValue((int)RefreshTokenFieldIndex.Id, true); }
			set	{ SetValue((int)RefreshTokenFieldIndex.Id, value); }
		}

		/// <summary>The IsActive property of the Entity RefreshToken<br/><br/></summary>
		/// <remarks>Mapped on  table field: "refresh_token"."is_active".<br/>Table field type characteristics (type, precision, scale, length): Boolean, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsActive
		{
			get { return (System.Boolean)GetValue((int)RefreshTokenFieldIndex.IsActive, true); }
			set	{ SetValue((int)RefreshTokenFieldIndex.IsActive, value); }
		}

		/// <summary>The TimeCreated property of the Entity RefreshToken<br/><br/></summary>
		/// <remarks>Mapped on  table field: "refresh_token"."time_created".<br/>Table field type characteristics (type, precision, scale, length): Timestamp, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime TimeCreated
		{
			get { return (System.DateTime)GetValue((int)RefreshTokenFieldIndex.TimeCreated, true); }
			set	{ SetValue((int)RefreshTokenFieldIndex.TimeCreated, value); }
		}

		/// <summary>The TimeExpires property of the Entity RefreshToken<br/><br/></summary>
		/// <remarks>Mapped on  table field: "refresh_token"."time_expires".<br/>Table field type characteristics (type, precision, scale, length): Timestamp, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime TimeExpires
		{
			get { return (System.DateTime)GetValue((int)RefreshTokenFieldIndex.TimeExpires, true); }
			set	{ SetValue((int)RefreshTokenFieldIndex.TimeExpires, value); }
		}

		/// <summary>The Token property of the Entity RefreshToken<br/><br/></summary>
		/// <remarks>Mapped on  table field: "refresh_token"."token".<br/>Table field type characteristics (type, precision, scale, length): Text, 0, 0, 1073741824.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Token
		{
			get { return (System.String)GetValue((int)RefreshTokenFieldIndex.Token, true); }
			set	{ SetValue((int)RefreshTokenFieldIndex.Token, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'UserEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(UserEntity))]
		public virtual EntityCollection<UserEntity> Users { get { return GetOrCreateEntityCollection<UserEntity, UserEntityFactory>("RefreshToken", true, false, ref _users); } }
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END


	}
}

namespace YumCity_Migrations
{
	public enum RefreshTokenFieldIndex
	{
		///<summary>Id. </summary>
		Id,
		///<summary>IsActive. </summary>
		IsActive,
		///<summary>TimeCreated. </summary>
		TimeCreated,
		///<summary>TimeExpires. </summary>
		TimeExpires,
		///<summary>Token. </summary>
		Token,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace YumCity_Migrations.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: RefreshToken. </summary>
	public partial class RefreshTokenRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between RefreshTokenEntity and UserEntity over the 1:n relation they have, using the relation between the fields: RefreshToken.Id - User.RefreshTokenId</summary>
		public virtual IEntityRelation UserEntityUsingRefreshTokenId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "Users", true, new[] { RefreshTokenFields.Id, UserFields.RefreshTokenId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticRefreshTokenRelations
	{
		internal static readonly IEntityRelation UserEntityUsingRefreshTokenIdStatic = new RefreshTokenRelations().UserEntityUsingRefreshTokenId;

		/// <summary>CTor</summary>
		static StaticRefreshTokenRelations() { }
	}
}
