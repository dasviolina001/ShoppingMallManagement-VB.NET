CREATE TABLE [dbo].[CategoriesTbl] (
    [CatId]   INT          NOT NULL IDENTITY,
    [CatName] VARCHAR (50) NOT NULL,
    [CatDesc] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([CatId] ASC)
);

