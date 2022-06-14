
const fila = document.querySelector('.contenedor-carousel');
const peliculas = document.querySelectorAll('.pelicula');

const flechaIzquierda = document.getElementById('flecha-izquierda');
const flechaDerecha = document.getElementById('flecha-derecha');

/* ? ----- ----- Event Listener para la flecha derecha. ----- -----*/
flechaDerecha.addEventListener('click', () => {
	fila.scrollLeft += fila.offsetWidth;

	//const indicadorActivo = document.querySelector('.indicadores .activo');
	//if(indicadorActivo.nextSibling){
	//	indicadorActivo.nextSibling.classList.add('activo');
	//	indicadorActivo.classList.remove('activo');
	//}
});

/* ? ----- ----- Event Listener para la flecha izquierda. ----- -----*/
flechaIzquierda.addEventListener('click', () => {
	fila.scrollLeft -= fila.offsetWidth;

	//const indicadorActivo = document.querySelector('.indicadores .activo');
	//if(indicadorActivo.previousSibling){
	//	indicadorActivo.previousSibling.classList.add('activo');
	//	indicadorActivo.classList.remove('activo');
	//}
});

// /*? ----- ----- Paginacion ----- -----*/
//const numeroPaginas = Math.ceil(peliculas.length / 5);
//for(let i = 0; i < numeroPaginas; i++){
//	const indicador = document.createElement('button');

//	if(i === 0){
//		indicador.classList.add('activo');
//	}

//	document.querySelector('.indicadores').appendChild(indicador);
//	indicador.addEventListener('click', (e) => {
//		fila.scrollLeft = i * fila.offsetWidth;

//		document.querySelector('.indicadores .activo').classList.remove('activo');
//		e.target.classList.add('activo');
//	});
//}
//************************carrusel2***************************************************
const fila2 = document.querySelector('.contenedor-carousel2');
const peliculas2 = document.querySelectorAll('.pelicula2');

const flechaIzquierda2 = document.getElementById('flecha-izquierda2');
const flechaDerecha2 = document.getElementById('flecha-derecha2');

// ? ----- ----- Event Listener para la flecha derecha. ----- -----
flechaDerecha2.addEventListener('click', () => {
	fila2.scrollLeft += fila2.offsetWidth;
});

// ? ----- ----- Event Listener para la flecha izquierda. ----- -----
flechaIzquierda2.addEventListener('click', () => {
	fila2.scrollLeft -= fila2.offsetWidth;
});
//************************carrusel3***************************************************
const fila3 = document.querySelector('.contenedor-carousel3');
const peliculas3 = document.querySelectorAll('.pelicula3');

const flechaIzquierda3 = document.getElementById('flecha-izquierda3');
const flechaDerecha3 = document.getElementById('flecha-derecha3');

// ? ----- ----- Event Listener para la flecha derecha. ----- -----
flechaDerecha3.addEventListener('click', () => {
	fila3.scrollLeft += fila3.offsetWidth;
});

// ? ----- ----- Event Listener para la flecha izquierda. ----- -----
flechaIzquierda3.addEventListener('click', () => {
	fila3.scrollLeft -= fila3.offsetWidth;
});
