@{
    Layout = null;  // If you don't want to use a layout page, or specify your layout
}

< !DOCTYPE html >
< html lang = "en" >

< head >
    < meta charset = "UTF-8" >
    < meta http - equiv = "X-UA-Compatible" content = "IE=edge" >
    < meta name = "viewport" content = "width=device-width, initial-scale=1.0" >
    < title > Wedding Booking Confirmation</title>
    <link rel = "stylesheet" href= "~/css/confirmation.css" > < !--Link to external CSS file -->
</head>

<body>
    <div class= "confirmation-message" >
        < h2 > Thank you for booking your wedding with us!</h2>
        <p>Your booking has been successfully received. We will contact you soon.</p>
        
        <!-- Return to Home button -->
        <a href="/Home/Index" class= "return-home-btn" > Return to Home</a>
    </div>
</body>

</html>
