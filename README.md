# E-Gram Open source project for making India's Panchayats digitalised.
E-Gram is a cloud based platform built exclusively for Grama Panchayats in Kerala. E-gram is a powerful data analytic tool which stores and analyses all the information regarding people in a panchayat. E-Gram generates real-time analytics on Population, Literacy Rate, Male-Female ratio, Poverty Threshold, Internet Penetration, Access to electricity (percentage), Access to clean water (percentage), Healthcare and many more. E-Gram's objective is to make Panchayats more efficient, transparent and symbols of modernity by leveraging ICT at the cutting edge level to ensure transparency and accountability in their functioning through disclosure of informaton, social audit, efficient delivery of services and improving internal processes and management of Panchayats


# Who can contribute.
Anyone who is interested in contributing towards this project can email me @ alokbabu@nextuz.com

# Configuring Database
Add appsettings.Development.config to EGram.Data.SQL.Ef project.
Add your connectionstring.

# EF Migrations

Navigate to EGram.Data.SQL.Ef. In Terminal type

```Terminal
dotnet ef database update
```

To Recreate migration

```Terminal
dotnet ef add InitalCreate
```

Remove Migration

```Terminal
dotnet ef remove
```

[Website](http://nextuz.com/)
[E-Gram](http://nextuz.com/products/egram)
