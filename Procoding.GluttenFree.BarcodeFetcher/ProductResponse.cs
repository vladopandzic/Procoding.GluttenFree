using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procoding.GluttenFree.BarcodeFetcher;

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

public class ProductResponse
{
    [JsonProperty("count")]
    public string Count { get; set; }

    [JsonProperty("page")]
    public string Page { get; set; }

    [JsonProperty("page_count")]
    public int PageCount { get; set; }

    [JsonProperty("page_size")]
    public int PageSize { get; set; }

    [JsonProperty("products")]
    public List<Product> Products { get; set; }
}

public class Product
{
    [JsonProperty("_id")]
    public string Id { get; set; }

    [JsonProperty("_keywords")]
    public List<string> Keywords { get; set; }

    [JsonProperty("added_countries_tags")]
    public List<string> AddedCountriesTags { get; set; }

    [JsonProperty("allergens")]
    public string Allergens { get; set; }

    [JsonProperty("allergens_from_ingredients")]
    public string AllergensFromIngredients { get; set; }

    [JsonProperty("allergens_from_user")]
    public string AllergensFromUser { get; set; }

    [JsonProperty("allergens_hierarchy")]
    public List<string> AllergensHierarchy { get; set; }

    [JsonProperty("allergens_tags")]
    public List<string> AllergensTags { get; set; }

    [JsonProperty("brands")]
    public string Brands { get; set; }

    [JsonProperty("brands_tags")]
    public List<string> BrandsTags { get; set; }

    //[JsonProperty("categories_properties")]
    //public object CategoriesProperties { get; set; }

    [JsonProperty("categories_properties_tags")]
    public List<string> CategoriesPropertiesTags { get; set; }

    [JsonProperty("checkers_tags")]
    public List<string> CheckersTags { get; set; }

    [JsonProperty("code")]
    public string Code { get; set; }

    [JsonProperty("codes_tags")]
    public List<string> CodesTags { get; set; }

    [JsonProperty("complete")]
    public int Complete { get; set; }

    [JsonProperty("completeness")]
    public string Completeness { get; set; }

    [JsonProperty("correctors_tags")]
    public List<string> CorrectorsTags { get; set; }

    [JsonProperty("countries")]
    public string Countries { get; set; }

    [JsonProperty("countries_hierarchy")]
    public List<string> CountriesHierarchy { get; set; }

    [JsonProperty("countries_tags")]
    public List<string> CountriesTags { get; set; }

    [JsonProperty("created_t")]
    public long CreatedT { get; set; }

    [JsonProperty("creator")]
    public string Creator { get; set; }

    [JsonProperty("data_quality_bugs_tags")]
    public List<string> DataQualityBugsTags { get; set; }

    [JsonProperty("data_quality_errors_tags")]
    public List<string> DataQualityErrorsTags { get; set; }

    [JsonProperty("data_quality_info_tags")]
    public List<string> DataQualityInfoTags { get; set; }

    [JsonProperty("data_quality_tags")]
    public List<string> DataQualityTags { get; set; }

    [JsonProperty("data_quality_warnings_tags")]
    public List<string> DataQualityWarningsTags { get; set; }

    [JsonProperty("data_sources")]
    public string DataSources { get; set; }

    [JsonProperty("data_sources_tags")]
    public List<string> DataSourcesTags { get; set; }

    [JsonProperty("ecoscore_data")]
    public EcoscoreData EcoscoreData { get; set; }

    [JsonProperty("ecoscore_grade")]
    public string EcoscoreGrade { get; set; }

    [JsonProperty("ecoscore_tags")]
    public List<string> EcoscoreTags { get; set; }

    [JsonProperty("editors_tags")]
    public List<string> EditorsTags { get; set; }

    [JsonProperty("entry_dates_tags")]
    public List<string> EntryDatesTags { get; set; }

    [JsonProperty("food_groups_tags")]
    public List<string> FoodGroupsTags { get; set; }

    [JsonProperty("id")]
    public string ProductId { get; set; }

    [JsonProperty("informers_tags")]
    public List<string> InformersTags { get; set; }

    [JsonProperty("ingredients_lc")]
    public string IngredientsLc { get; set; }

    [JsonProperty("interface_version_created")]
    public string InterfaceVersionCreated { get; set; }

    [JsonProperty("interface_version_modified")]
    public string InterfaceVersionModified { get; set; }

    [JsonProperty("lang")]
    public string Lang { get; set; }

    [JsonProperty("languages")]
    public Dictionary<string, int> Languages { get; set; }

    [JsonProperty("languages_codes")]
    public Dictionary<string, int> LanguagesCodes { get; set; }

    [JsonProperty("languages_hierarchy")]
    public List<string> LanguagesHierarchy { get; set; }

    [JsonProperty("languages_tags")]
    public List<string> LanguagesTags { get; set; }

    [JsonProperty("last_edit_dates_tags")]
    public List<string> LastEditDatesTags { get; set; }

    [JsonProperty("last_editor")]
    public string LastEditor { get; set; }

    [JsonProperty("last_modified_by")]
    public string LastModifiedBy { get; set; }

    [JsonProperty("last_modified_t")]
    public long LastModifiedT { get; set; }

    [JsonProperty("last_updated_t")]
    public long LastUpdatedT { get; set; }

    [JsonProperty("lc")]
    public string Lc { get; set; }

    [JsonProperty("main_countries_tags")]
    public List<string> MainCountriesTags { get; set; }

    [JsonProperty("misc_tags")]
    public List<string> MiscTags { get; set; }

    [JsonProperty("no_nutrition_data")]
    public string NoNutritionData { get; set; }

    [JsonProperty("nova_group_debug")]
    public string NovaGroupDebug { get; set; }

    [JsonProperty("nova_group_error")]
    public string NovaGroupError { get; set; }

    [JsonProperty("nova_groups_tags")]
    public List<string> NovaGroupsTags { get; set; }

    [JsonProperty("nutrient_levels")]
    public Dictionary<string, string> NutrientLevels { get; set; }

    [JsonProperty("nutrient_levels_tags")]
    public List<string> NutrientLevelsTags { get; set; }

    [JsonProperty("nutriments")]
    public Nutriments Nutriments { get; set; }

    [JsonProperty("nutriscore")]
    public Nutriscore Nutriscore { get; set; }

    [JsonProperty("nutriscore_2021_tags")]
    public List<string> Nutriscore2021Tags { get; set; }

    [JsonProperty("nutriscore_2023_tags")]
    public List<string> Nutriscore2023Tags { get; set; }

    [JsonProperty("nutriscore_grade")]
    public string NutriscoreGrade { get; set; }

    [JsonProperty("nutriscore_tags")]
    public List<string> NutriscoreTags { get; set; }

    [JsonProperty("nutriscore_version")]
    public string NutriscoreVersion { get; set; }

    [JsonProperty("nutrition_data")]
    public string NutritionData { get; set; }

    [JsonProperty("nutrition_data_per")]
    public string NutritionDataPer { get; set; }

    [JsonProperty("nutrition_data_prepared_per")]
    public string NutritionDataPreparedPer { get; set; }

    [JsonProperty("nutrition_grade_fr")]
    public string NutritionGradeFr { get; set; }

    [JsonProperty("nutrition_grades")]
    public string NutritionGrades { get; set; }

    [JsonProperty("nutrition_grades_tags")]
    public List<string> NutritionGradesTags { get; set; }

    [JsonProperty("nutrition_score_beverage")]
    public int NutritionScoreBeverage { get; set; }

    [JsonProperty("nutrition_score_debug")]
    public string NutritionScoreDebug { get; set; }

    [JsonProperty("nutrition_score_warning_no_fiber")]
    public int NutritionScoreWarningNoFiber { get; set; }

    [JsonProperty("nutrition_score_warning_no_fruits_vegetables_nuts")]
    public int NutritionScoreWarningNoFruitsVegetablesNuts { get; set; }

    [JsonProperty("packaging_materials_tags")]
    public List<string> PackagingMaterialsTags { get; set; }

    [JsonProperty("packaging_recycling_tags")]
    public List<string> PackagingRecyclingTags { get; set; }

    [JsonProperty("packaging_shapes_tags")]
    public List<string> PackagingShapesTags { get; set; } = [];

    //[JsonProperty("packagings")]
    //public List<object> Packagings { get; set; }

    [JsonProperty("packagings_materials")]
    public Dictionary<string, string> PackagingsMaterials { get; set; }

    [JsonProperty("photographers_tags")]
    public List<string> PhotographersTags { get; set; } = [];

    [JsonProperty("pnns_groups_1")]
    public string? PnnsGroups1 { get; set; }

    [JsonProperty("pnns_groups_1_tags")]
    public List<string> PnnsGroups1Tags { get; set; } = [];

    [JsonProperty("pnns_groups_2")]
    public string PnnsGroups2 { get; set; }

    [JsonProperty("pnns_groups_2_tags")]
    public List<string> PnnsGroups2Tags { get; set; }

    [JsonProperty("popularity_key")]
    public int PopularityKey { get; set; }

    [JsonProperty("product_name")]
    public string ProductName { get; set; }

    [JsonProperty("product_name_hr")]
    public string ProductNameHr { get; set; }

    [JsonProperty("product_type")]
    public string ProductType { get; set; }

    [JsonProperty("removed_countries_tags")]
    public List<string> RemovedCountriesTags { get; set; }

    [JsonProperty("rev")]
    public int Rev { get; set; }

    [JsonProperty("serving_quantity")]
    public string ServingQuantity { get; set; }

    [JsonProperty("serving_quantity_unit")]
    public string ServingQuantityUnit { get; set; }

    [JsonProperty("serving_size")]
    public string ServingSize { get; set; }

    [JsonProperty("states")]
    public string States { get; set; }

    [JsonProperty("states_hierarchy")]
    public List<string> StatesHierarchy { get; set; }

    [JsonProperty("states_tags")]
    public List<string> StatesTags { get; set; }

    [JsonProperty("traces")]
    public string Traces { get; set; }

    [JsonProperty("traces_from_ingredients")]
    public string TracesFromIngredients { get; set; }

    [JsonProperty("traces_from_user")]
    public string TracesFromUser { get; set; }

    [JsonProperty("traces_hierarchy")]
    public List<string> TracesHierarchy { get; set; }

    [JsonProperty("traces_tags")]
    public List<string> TracesTags { get; set; }

    [JsonProperty("unknown_nutrients_tags")]
    public List<string> UnknownNutrientsTags { get; set; }

    [JsonProperty("update_key")]
    public string UpdateKey { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("weighers_tags")]
    public List<string> WeighersTags { get; set; }
}

public class EcoscoreData
{
    [JsonProperty("adjustments")]
    public Adjustments Adjustments { get; set; }

    [JsonProperty("packaging")]
    public Packaging Packaging { get; set; }

    [JsonProperty("production_system")]
    public ProductionSystem ProductionSystem { get; set; }

    [JsonProperty("threatened_species")]
    public ThreatenedSpecies ThreatenedSpecies { get; set; }

    [JsonProperty("agribalyse")]
    public Agribalyse Agribalyse { get; set; }

    [JsonProperty("missing")]
    public Missing Missing { get; set; }

    [JsonProperty("missing_agribalyse_match_warning")]
    public int MissingAgribalyseMatchWarning { get; set; }

    [JsonProperty("missing_key_data")]
    public int MissingKeyData { get; set; }

    [JsonProperty("scores")]
    public Dictionary<string, string> Scores { get; set; }
}

public class Adjustments
{
    [JsonProperty("organic")]
    public bool Organic { get; set; }

    [JsonProperty("nitrates")]
    public bool Nitrates { get; set; }

    [JsonProperty("impacts")]
    public bool Impacts { get; set; }

    [JsonProperty("livestock")]
    public bool Livestock { get; set; }
}

public class Packaging
{
    [JsonProperty("material")]
    public string Material { get; set; }

    [JsonProperty("mass")]
    public double Mass { get; set; }

    [JsonProperty("tags")]
    public List<string> Tags { get; set; }
}

public class ProductionSystem
{
    [JsonProperty("agriculture")]
    public string Agriculture { get; set; }

    [JsonProperty("industrial")]
    public string Industrial { get; set; }

    [JsonProperty("transport")]
    public string Transport { get; set; }

    [JsonProperty("packaging")]
    public string Packaging { get; set; }
}

public class ThreatenedSpecies
{
    [JsonProperty("species_tags")]
    public List<string> SpeciesTags { get; set; }

    [JsonProperty("categories_tags")]
    public List<string> CategoriesTags { get; set; }
}

public class Agribalyse
{
    [JsonProperty("adjustments")]
    public Adjustments Adjustments { get; set; }

    [JsonProperty("impacts")]
    public bool Impacts { get; set; }
}

public class Missing
{
    [JsonProperty("packaging")]
    public bool Packaging { get; set; }

    [JsonProperty("product")]
    public bool Product { get; set; }

    [JsonProperty("ecoscore")]
    public bool Ecoscore { get; set; }

    [JsonProperty("food_quality")]
    public bool FoodQuality { get; set; }
}

public class Nutriments
{
    [JsonProperty("fat")]
    public double Fat { get; set; }

    [JsonProperty("saturated_fat")]
    public double SaturatedFat { get; set; }

    [JsonProperty("sugars")]
    public double Sugars { get; set; }

    [JsonProperty("salt")]
    public double Salt { get; set; }

    [JsonProperty("energy")]
    public double Energy { get; set; }

    [JsonProperty("energy_kcal")]
    public double EnergyKcal { get; set; }

    [JsonProperty("protein")]
    public double Protein { get; set; }

    [JsonProperty("carbohydrates")]
    public double Carbohydrates { get; set; }
}

public class Nutriscore
{
    [JsonProperty("grade")]
    public string Grade { get; set; }

    [JsonProperty("comments")]
    public List<string> Comments { get; set; }
}
