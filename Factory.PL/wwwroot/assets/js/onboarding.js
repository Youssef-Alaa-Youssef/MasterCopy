$(document).ready(function () {
    function animateOnScroll() {
        $('.animate-on-scroll').each(function () {
            const elementTop = $(this).offset().top;
            const elementHeight = $(this).height();
            const windowHeight = $(window).height();
            const scrollY = window.scrollY || window.pageYOffset;

            if (scrollY > elementTop - windowHeight + elementHeight / 4) {
                const animationClass = $(this).data('animation') || 'fadeIn';
                $(this).addClass('animate__' + animationClass);
                $(this).removeClass('animate-on-scroll');
            }
        });
    }

    animateOnScroll();
    $(window).scroll(animateOnScroll);

    $('[data-toggle="tooltip"]').tooltip();

    $('.feature-list li').hover(
        function () {
            $(this).addClass('animate__pulse');
        },
        function () {
            $(this).removeClass('animate__pulse');
        }
    );
});