var swiper = new Swiper(".mySwiper", {
    spaceBetween: 50,
    pagination: {
      el: ".swiper-pagination",
      clickable: true,
    },
  });
  var swiper2 = new Swiper(".mySwiper2", {
    direction: "vertical",
    spaceBetween: 50,
    pagination: {
      el: ".swiper-pagination",
      clickable: true,
    },
  });
  var swiper = new Swiper(".mySwiper", {
    navigation: {
      nextEl: ".swiper-button-next",
      prevEl: ".swiper-button-prev",
    },
  });