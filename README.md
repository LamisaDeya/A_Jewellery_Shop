# A Jewellery Shop Website

## Overview
This project is an e-commerce website for a Jewellery Shop, built using **HTML**, **CSS**, **JavaScript**, and **ASP.NET Framework**. It consists of an **Admin Panel**, **User Panel**, and a **Default Panel** where visitors can browse products without registering. The website dynamically updates based on admin input, and users can manage their shopping experience through features like sorting, cart management, and subscriptions.

## Features

### Admin Panel
- **Category Management**: Admin can add, update, or delete product categories, subcategories, and brand names.
- **Product Management**: Admin can add new products with details like images, categories, subcategories, and brands. Products can be edited or deleted as needed.
- **Inventory Management**: Admin can track product quantities, and when a product runs out of stock, it becomes unavailable for users to purchase.
- **Order Management**: Admin can view user orders and update the order status from "Pending" to "Done" upon delivery. Automated emails are sent to users when an order is received and when it is delivered.
- **Subscriber Management**: Admin can view the list of email subscribers and send them automated messages about new products or offers.
- **Automatic Email Notifications**: The system sends email notifications to users when their order status changes and when new offers or products are added.
- **Product Quantity Tracking**: For every product purchase, the system reduces the quantity. If the quantity reaches zero, the product becomes unavailable for purchase.

### User Panel
- **Product Browsing**: Users can view products dynamically displayed based on admin input. They can sort products in various ways:
  - Alphabetically (ascending/descending)
  - Date-wise (newest/oldest)
  - Price-wise (lowest/highest)
- **Product Search and Filtering**: Users can search and filter products by category, subcategory, or brand via dropdown menus.
- **Cart Management**: Users can add products to their cart, view the total cost, and manage quantities. They can:
  - Add or remove products
  - Increase or decrease product quantities
- **Session & Cookies**: Each user’s cart is stored in the session, so users can only view and manage their own cart.
- **Checkout Process**: Users can proceed to checkout, fill in their details, and make a payment. Upon checkout, an email confirmation is sent to the user.
- **Subscription**: Users can subscribe using their email to receive notifications about new products and offers. Subscribers get automated emails with product links.

### Default Panel
- **Guest Browsing**: Any visitor (without registering) can view products on the website.
- **Dynamic Product Display**: All product listings are dynamically updated by the admin and displayed to users.

## Technologies Used
- **Frontend**: 
  - HTML
  - CSS
  - JavaScript
- **Backend**: 
  - ASP.NET Framework
- **Database**: 
  - SQL Server (for storing product, category, user, and order details)
- **Email System**: 
  - Integrated email notifications using SMTP for sending emails about orders and offers.
  
## Installation and Setup
1. **Clone the Repository**:
   ```bash
   git clone https://github.com/YourUsername/JewelleryShop.git
   ```
2. **Open in Visual Studio Code**:
   - Open the project in **Visual Studio Code**.

3. **Database Setup**:
   - Set up a **SQL Server** database for storing product, user, order, and subscription details.
   - Update the database connection string in the `web.config` file.

4. **Configure Email Settings**:
   - Set up your email server credentials in the `web.config` for sending automated emails.

5. **Run the Project**:
   - Run the project from **Visual Studio** and navigate to the website's home page.

## Key Functionalities

### Admin Features:
- Add, update, or delete categories, subcategories, and brands.
- Add new products with images, and edit or delete products.
- Manage product inventory and update quantities.
- View and manage user orders, update order status, and send email notifications.
- Manage subscribers and send automated marketing emails.

### User Features:
- Browse products dynamically added by the admin.
- Sort and filter products by category, subcategory, brand, price, and date.
- Manage their cart with session-based cart storage.
- Subscribe to notifications about new products and offers.
- Receive email updates about orders and offers.

### Default Panel Features:
- Browse the website and products without registering.
- View products with all filtering and sorting options.

## Future Improvements
- **Payment Gateway Integration**: Add real-time payment processing for smoother transactions.
- **Advanced Analytics**: Provide detailed insights for admins on sales, popular products, and user behavior.
- **Enhanced Security**: Implement enhanced security features such as two-factor authentication (2FA) for admins and users.
- **Wishlist Feature**: Allow users to add products to a wishlist for future purchases.

## Contributor
- **Lamisa Bintee Mizan Deya** 
