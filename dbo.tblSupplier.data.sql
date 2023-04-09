SET IDENTITY_INSERT [dbo].[tblSupplier] ON
INSERT INTO [dbo].[tblSupplier] ([SupplierID], [SupplierName], [SupplierItem], [SupplierItemCost], [EstimateDelivery], [SupplierIteamStatus]) VALUES (1, Smith, Charis, 210,01/12/2019,True)
INSERT INTO [dbo].[tblSupplier] ([SupplierID], [SupplierName], [SupplierItem], [SupplierItemCost], [EstimateDelivery], [SupplierIteamStatus]) VALUES (2, Williams, CoffeeTable, 95,26/12/2019,True)
SET IDENTITY_INSERT [dbo].[tblSupplier] OFF
