document.querySelectorAll('#manual .lista-manual a').forEach((elemento) => {
    elemento.addEventListener('click', () => {
        document.querySelector('#manual .activo').classList.remove('activo');
        elemento.parentElement.classList.add('activo');
    });
});

