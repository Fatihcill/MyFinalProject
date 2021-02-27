
namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product Added";
        public static string ProductNameInvalid = "The Product Name must consist of a minimum of 2 characters.";
        public static string MaintenanceTime = "The system will work soon.";
        public static string ProductsListed = "Products Listed";
        public static string UnitPriceInvalid = "Products prices must be higher than 0";
        public static string ProductCountOfCategoryError="In a category must have 10 products";
        public static string AuthorizationDenied = "Authorization Denied";
        public static string ProductNameAlreadyExists ="Product name already exists";
        public static string CategoryLimitExceded ="Cannot add products because category limit is exceeded";

        public static string UserRegistered = "UserRegistered";
        public static string UserNotFound = "UserNotFound";
        public static string PasswordError = "PasswordError";
        public static string SuccessfulLogin = "SuccessfulLogin";
        public static string UserAlreadyExists = "UserAlreadyExists";
        public static string AccessTokenCreated = "AccessTokenCreated";
    }
}