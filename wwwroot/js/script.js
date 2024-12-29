document.getElementById('loginButton').addEventListener('click', function(event) {
    event.preventDefault(); // يمنع السلوك الافتراضي لو كان الزر داخل فورم
    window.location.href = 'login.html'; // تأكد إن المسار صحيح
});

// إضافة مستمع للأحداث على زر البحث
document.querySelector(".search-btn").addEventListener("click", function() {
    const searchInput = document.querySelector(".search-input");
    // التبديل بين إظهار وإخفاء حقل البحث
    searchInput.classList.toggle("active");
});

// حذف النص الافتراضي عند الكتابة في حقل البحث
document.querySelector(".search-input").addEventListener("focus", function() {
    if (this.value === "") {
        this.placeholder = ""; // إخفاء النص الافتراضي عند التركيز على الحقل
    }
});

// إعادة النص الافتراضي إذا لم يتم كتابة شيء
document.querySelector(".search-input").addEventListener("blur", function() {
    if (this.value === "") {
        this.placeholder = "What are you looking for..."; // إظهار النص الافتراضي إذا كان الحقل فارغ
    }
});
// Function to add items to the cart
function addToCart(itemName, itemPrice) {
    // Get existing cart data from Local Storage
    let cart = JSON.parse(localStorage.getItem("cart")) || [];

    // Add the new item to the cart
    cart.push({ name: itemName, price: itemPrice });

    // Save updated cart back to Local Storage
    localStorage.setItem("cart", JSON.stringify(cart));

    // Show confirmation message
    alert(`${itemName} has been added to your cart!`);
}


