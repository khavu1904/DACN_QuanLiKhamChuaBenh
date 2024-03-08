
document.getElementById("searchForm").addEventListener("submit", function (event) {
    var phoneNumberInput = document.getElementById("phoneNumber");
    var phoneNumberValue = phoneNumberInput.value.trim();

    // Kiểm tra xem số điện thoại có đủ 10 chữ số hay không
    if (phoneNumberValue.length !== 10) {
        alert("Số điện thoại phải có đúng 10 chữ số.");
        event.preventDefault(); // Ngăn không gửi form đi
    }
});
