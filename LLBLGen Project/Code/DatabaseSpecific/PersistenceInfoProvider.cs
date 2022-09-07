﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro v5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace YumCity_Migrations.DatabaseSpecific
{
	/// <summary>Singleton implementation of the PersistenceInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	internal static class PersistenceInfoProviderSingleton
	{
		private static readonly IPersistenceInfoProvider _providerInstance = new PersistenceInfoProviderCore();

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static PersistenceInfoProviderSingleton() {	}

		/// <summary>Gets the singleton instance of the PersistenceInfoProviderCore</summary>
		/// <returns>Instance of the PersistenceInfoProvider.</returns>
		public static IPersistenceInfoProvider GetInstance() { return _providerInstance; }
	}

	/// <summary>Actual implementation of the PersistenceInfoProvider. Used by singleton wrapper.</summary>
	internal class PersistenceInfoProviderCore : PersistenceInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="PersistenceInfoProviderCore"/> class.</summary>
		internal PersistenceInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores with the structure of hierarchical types.</summary>
		private void Init()
		{
			this.InitClass();
			InitCategoryEntityMappings();
			InitIngredientEntityMappings();
			InitInstructionEntityMappings();
			InitRecipeEntityMappings();
			InitRecipeCategoryEntityMappings();
			InitRefreshTokenEntityMappings();
			InitUserEntityMappings();
		}

		/// <summary>Inits CategoryEntity's mappings</summary>
		private void InitCategoryEntityMappings()
		{
			this.AddElementMapping("CategoryEntity", @"YumCity", @"public", "Category", 2, 0);
			this.AddElementFieldMapping("CategoryEntity", "Data", "Data", false, "Text", 1073741824, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("CategoryEntity", "Id", "Id", false, "Uuid", 0, 0, 0, false, "", null, typeof(System.Guid), 1);
		}

		/// <summary>Inits IngredientEntity's mappings</summary>
		private void InitIngredientEntityMappings()
		{
			this.AddElementMapping("IngredientEntity", @"YumCity", @"public", "Ingredient", 3, 0);
			this.AddElementFieldMapping("IngredientEntity", "Data", "Data", false, "Text", 1073741824, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("IngredientEntity", "Id", "Id", false, "Uuid", 0, 0, 0, false, "", null, typeof(System.Guid), 1);
			this.AddElementFieldMapping("IngredientEntity", "RecipeId", "RecipeId", false, "Uuid", 0, 0, 0, false, "", null, typeof(System.Guid), 2);
		}

		/// <summary>Inits InstructionEntity's mappings</summary>
		private void InitInstructionEntityMappings()
		{
			this.AddElementMapping("InstructionEntity", @"YumCity", @"public", "Instruction", 3, 0);
			this.AddElementFieldMapping("InstructionEntity", "Data", "Data", false, "Text", 1073741824, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("InstructionEntity", "Id", "Id", false, "Uuid", 0, 0, 0, false, "", null, typeof(System.Guid), 1);
			this.AddElementFieldMapping("InstructionEntity", "RecipeId", "RecipeId", false, "Uuid", 0, 0, 0, false, "", null, typeof(System.Guid), 2);
		}

		/// <summary>Inits RecipeEntity's mappings</summary>
		private void InitRecipeEntityMappings()
		{
			this.AddElementMapping("RecipeEntity", @"YumCity", @"public", "Recipe", 3, 0);
			this.AddElementFieldMapping("RecipeEntity", "Id", "Id", false, "Uuid", 0, 0, 0, false, "", null, typeof(System.Guid), 0);
			this.AddElementFieldMapping("RecipeEntity", "Title", "Title", false, "Text", 1073741824, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("RecipeEntity", "UserId", "UserId", false, "Uuid", 0, 0, 0, false, "", null, typeof(System.Guid), 2);
		}

		/// <summary>Inits RecipeCategoryEntity's mappings</summary>
		private void InitRecipeCategoryEntityMappings()
		{
			this.AddElementMapping("RecipeCategoryEntity", @"YumCity", @"public", "RecipeCategory", 3, 0);
			this.AddElementFieldMapping("RecipeCategoryEntity", "Data", "Data", false, "Text", 1073741824, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("RecipeCategoryEntity", "Id", "Id", false, "Uuid", 0, 0, 0, false, "", null, typeof(System.Guid), 1);
			this.AddElementFieldMapping("RecipeCategoryEntity", "RecipeId", "RecipeId", false, "Uuid", 0, 0, 0, false, "", null, typeof(System.Guid), 2);
		}

		/// <summary>Inits RefreshTokenEntity's mappings</summary>
		private void InitRefreshTokenEntityMappings()
		{
			this.AddElementMapping("RefreshTokenEntity", @"YumCity", @"public", "RefreshToken", 4, 0);
			this.AddElementFieldMapping("RefreshTokenEntity", "Id", "Id", false, "Uuid", 0, 0, 0, false, "", null, typeof(System.Guid), 0);
			this.AddElementFieldMapping("RefreshTokenEntity", "TimeCreated", "TimeCreated", false, "Timestamp", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("RefreshTokenEntity", "TimeExpires", "TimeExpires", false, "Timestamp", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("RefreshTokenEntity", "Token", "Token", false, "Text", 1073741824, 0, 0, false, "", null, typeof(System.String), 3);
		}

		/// <summary>Inits UserEntity's mappings</summary>
		private void InitUserEntityMappings()
		{
			this.AddElementMapping("UserEntity", @"YumCity", @"public", "User", 4, 0);
			this.AddElementFieldMapping("UserEntity", "Id", "Id", false, "Uuid", 0, 0, 0, false, "", null, typeof(System.Guid), 0);
			this.AddElementFieldMapping("UserEntity", "Name", "Name", false, "Text", 1073741824, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("UserEntity", "PasswordHash", "PasswordHash", false, "Text", 1073741824, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("UserEntity", "RefreshTokenId", "RefreshTokenId", true, "Uuid", 0, 0, 0, false, "", null, typeof(System.Guid), 3);
		}

	}
}