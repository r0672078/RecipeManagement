SET IDENTITY_INSERT Chefs ON;
INSERT INTO Chefs (ChefId, Name) VALUES
    (1, 'Jamie Oliver'),
    (2, 'Gordon Ramsay'),
    (3, 'Nigella Lawson'),
    (4, 'Bobby Flay'),
    (5, 'Ina Garten');
SET IDENTITY_INSERT Chefs OFF;

SET IDENTITY_INSERT Ingredients ON;
INSERT INTO Ingredients (IngredientId, Name) VALUES
    (1, 'Salt'),
    (2, 'Pepper'),
    (3, 'Olive Oil'),
    (4, 'Chicken Breast'),
    (5, 'Tomatoes');
SET IDENTITY_INSERT Ingredients OFF;

SET IDENTITY_INSERT Categories ON;
INSERT INTO Categories (CategoryId, Name) VALUES
    (1, 'Appetizers'),
    (2, 'Main Dishes'),
    (3, 'Desserts'),
    (4, 'Salads'),
    (5, 'Beverages');
SET IDENTITY_INSERT Categories OFF;

SET IDENTITY_INSERT Recipes ON;
INSERT INTO Recipes (RecipeId, ChefId, Name, PreparationTime, CookingTime, Servings, Origin, Instructions) VALUES
    (1, 1, 'Roast Chicken', '15 minutes', '1 hour', 4, 'United Kingdom', 'Preheat the oven...'),
    (2, 2, 'Pasta Carbonara', '10 minutes', '20 minutes', 2, 'Italy', 'Boil the pasta...'),
    (3, 3, 'Chocolate Cake', '20 minutes', '30 minutes', 8, 'United States', 'Preheat the oven to 350°F...'),
    (4, 4, 'Grilled Steak', '5 minutes', '15 minutes', 2, 'United States', 'Season the steak...'),
    (5, 5, 'Margarita', '5 minutes', '0 minutes', 1, 'Mexico', 'Mix tequila, lime juice, and triple sec...');
SET IDENTITY_INSERT Recipes OFF;

SET IDENTITY_INSERT RecipeIngredients ON;
INSERT INTO RecipeIngredients (RecipeIngredientId, RecipeId, IngredientId, Quantity) VALUES
    (1, 1, 4, 4.0),
    (2, 2, 2, 1.0),
    (3, 3, 3, 0.75),
    (4, 4, 5, 2.0),
    (5, 5, 1, 1.0);
SET IDENTITY_INSERT RecipeIngredients OFF;

SET IDENTITY_INSERT RecipeCategories ON;
INSERT INTO RecipeCategories (RecipeCategoryId, RecipeId, CategoryId) VALUES
    (1, 1, 2),
    (2, 2, 2),
    (3, 3, 3),
    (4, 4, 2),
    (5, 5, 5);
SET IDENTITY_INSERT RecipeCategories OFF;