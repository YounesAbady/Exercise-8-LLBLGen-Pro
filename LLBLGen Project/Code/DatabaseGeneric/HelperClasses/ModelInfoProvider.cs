﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro v5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using YumCity_Migrations.FactoryClasses;
using YumCity_Migrations.RelationClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace YumCity_Migrations.HelperClasses
{
	/// <summary>Singleton implementation of the ModelInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	public static class ModelInfoProviderSingleton
	{
		private static readonly IModelInfoProvider _providerInstance = new ModelInfoProviderCore();

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static ModelInfoProviderSingleton()	{ }

		/// <summary>Gets the singleton instance of the ModelInfoProviderCore</summary>
		/// <returns>Instance of the FieldInfoProvider.</returns>
		public static IModelInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the ModelInfoProvider.</summary>
	internal class ModelInfoProviderCore : ModelInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="ModelInfoProviderCore"/> class.</summary>
		internal ModelInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores.</summary>
		private void Init()
		{
			this.InitClass();
			InitCategoryEntityInfo();
			InitIngredientEntityInfo();
			InitInstructionEntityInfo();
			InitRecipeEntityInfo();
			InitRecipeCategoryEntityInfo();
			InitRefreshTokenEntityInfo();
			InitUserEntityInfo();
			this.BuildInternalStructures();
		}

		/// <summary>Inits CategoryEntity's info objects</summary>
		private void InitCategoryEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(CategoryFieldIndex), "CategoryEntity");
			this.AddElementFieldInfo("CategoryEntity", "Data", typeof(System.String), false, false, false, false,  (int)CategoryFieldIndex.Data, 1073741824, 0, 0);
			this.AddElementFieldInfo("CategoryEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)CategoryFieldIndex.Id, 0, 0, 0);
		}

		/// <summary>Inits IngredientEntity's info objects</summary>
		private void InitIngredientEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(IngredientFieldIndex), "IngredientEntity");
			this.AddElementFieldInfo("IngredientEntity", "Data", typeof(System.String), false, false, false, false,  (int)IngredientFieldIndex.Data, 1073741824, 0, 0);
			this.AddElementFieldInfo("IngredientEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)IngredientFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("IngredientEntity", "RecipeId", typeof(System.Guid), false, true, false, false,  (int)IngredientFieldIndex.RecipeId, 0, 0, 0);
		}

		/// <summary>Inits InstructionEntity's info objects</summary>
		private void InitInstructionEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(InstructionFieldIndex), "InstructionEntity");
			this.AddElementFieldInfo("InstructionEntity", "Data", typeof(System.String), false, false, false, false,  (int)InstructionFieldIndex.Data, 1073741824, 0, 0);
			this.AddElementFieldInfo("InstructionEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)InstructionFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("InstructionEntity", "RecipeId", typeof(System.Guid), false, true, false, false,  (int)InstructionFieldIndex.RecipeId, 0, 0, 0);
		}

		/// <summary>Inits RecipeEntity's info objects</summary>
		private void InitRecipeEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(RecipeFieldIndex), "RecipeEntity");
			this.AddElementFieldInfo("RecipeEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)RecipeFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("RecipeEntity", "Title", typeof(System.String), false, false, false, false,  (int)RecipeFieldIndex.Title, 1073741824, 0, 0);
			this.AddElementFieldInfo("RecipeEntity", "UserId", typeof(System.Guid), false, true, false, false,  (int)RecipeFieldIndex.UserId, 0, 0, 0);
		}

		/// <summary>Inits RecipeCategoryEntity's info objects</summary>
		private void InitRecipeCategoryEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(RecipeCategoryFieldIndex), "RecipeCategoryEntity");
			this.AddElementFieldInfo("RecipeCategoryEntity", "Data", typeof(System.String), false, false, false, false,  (int)RecipeCategoryFieldIndex.Data, 1073741824, 0, 0);
			this.AddElementFieldInfo("RecipeCategoryEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)RecipeCategoryFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("RecipeCategoryEntity", "RecipeId", typeof(System.Guid), false, true, false, false,  (int)RecipeCategoryFieldIndex.RecipeId, 0, 0, 0);
		}

		/// <summary>Inits RefreshTokenEntity's info objects</summary>
		private void InitRefreshTokenEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(RefreshTokenFieldIndex), "RefreshTokenEntity");
			this.AddElementFieldInfo("RefreshTokenEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)RefreshTokenFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("RefreshTokenEntity", "TimeCreated", typeof(System.DateTime), false, false, false, false,  (int)RefreshTokenFieldIndex.TimeCreated, 0, 0, 0);
			this.AddElementFieldInfo("RefreshTokenEntity", "TimeExpires", typeof(System.DateTime), false, false, false, false,  (int)RefreshTokenFieldIndex.TimeExpires, 0, 0, 0);
			this.AddElementFieldInfo("RefreshTokenEntity", "Token", typeof(System.String), false, false, false, false,  (int)RefreshTokenFieldIndex.Token, 1073741824, 0, 0);
		}

		/// <summary>Inits UserEntity's info objects</summary>
		private void InitUserEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(UserFieldIndex), "UserEntity");
			this.AddElementFieldInfo("UserEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)UserFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("UserEntity", "Name", typeof(System.String), false, false, false, false,  (int)UserFieldIndex.Name, 1073741824, 0, 0);
			this.AddElementFieldInfo("UserEntity", "PasswordHash", typeof(System.String), false, false, false, false,  (int)UserFieldIndex.PasswordHash, 1073741824, 0, 0);
			this.AddElementFieldInfo("UserEntity", "RefreshTokenId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)UserFieldIndex.RefreshTokenId, 0, 0, 0);
		}
	}
}