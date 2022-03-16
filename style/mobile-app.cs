input::-webkit-outer-spin-button,
input::-webkit-inner-spin-button {
  -webkit-appearance: none;
  margin: 0;
}

img {
  max-width: 100%;
}

video {
  max-width: 100%;
}

/*! normalize.css v8.0.1 | MIT License | github.com/necolas/normalize.css */
/* Document
   ========================================================================== */
/**
 * 1. Correct the line height in all browsers.
 * 2. Prevent adjustments of font size after orientation changes in iOS.
 */
html {
  line-height: 1.15;
  /* 1 */
  -webkit-text-size-adjust: 100%;
  /* 2 */
}

/* Sections
   ========================================================================== */
/**
 * Remove the margin in all browsers.
 */
body {
  margin: 0;
}

/**
 * Render the `main` element consistently in IE.
 */
main {
  display: block;
}

/**
 * Correct the font size and margin on `h1` elements within `section` and
 * `article` contexts in Chrome, Firefox, and Safari.
 */
h1, h2, h3, h4, h5, h6, p, a {
  margin: 0;
}

/* Grouping content
   ========================================================================== */
/**
 * 1. Add the correct box sizing in Firefox.
 * 2. Show the overflow in Edge and IE.
 */
hr {
  box-sizing: content-box;
  /* 1 */
  height: 0;
  /* 1 */
  overflow: visible;
  /* 2 */
}

/**
 * 1. Correct the inheritance and scaling of font size in all browsers.
 * 2. Correct the odd `em` font sizing in all browsers.
 */
pre {
  font-family: monospace, monospace;
  /* 1 */
  font-size: 1em;
  /* 2 */
}

/* Text-level semantics
   ========================================================================== */
/**
 * Remove the gray background on active links in IE 10.
 */
a {
  background-color: transparent;
}

/**
 * 1. Remove the bottom border in Chrome 57-
 * 2. Add the correct text decoration in Chrome, Edge, IE, Opera, and Safari.
 */
abbr[title] {
  border-bottom: none;
  /* 1 */
  text-decoration: underline;
  /* 2 */
  text-decoration: underline dotted;
  /* 2 */
}

/**
 * Add the correct font weight in Chrome, Edge, and Safari.
 */
b,
strong {
  font-weight: bolder;
}

/**
 * 1. Correct the inheritance and scaling of font size in all browsers.
 * 2. Correct the odd `em` font sizing in all browsers.
 */
code,
kbd,
samp {
  font-family: monospace, monospace;
  /* 1 */
  font-size: 1em;
  /* 2 */
}

/**
 * Add the correct font size in all browsers.
 */
small {
  font-size: 80%;
}

/**
 * Prevent `sub` and `sup` elements from affecting the line height in
 * all browsers.
 */
sub,
sup {
  font-size: 75%;
  line-height: 0;
  position: relative;
  vertical-align: baseline;
}

sub {
  bottom: -0.25em;
}

sup {
  top: -0.5em;
}

/* Embedded content
   ========================================================================== */
/**
 * Remove the border on images inside links in IE 10.
 */
img {
  border-style: none;
}

/* Forms
   ========================================================================== */
/**
 * 1. Change the font styles in all browsers.
 * 2. Remove the margin in Firefox and Safari.
 */
form {
  margin: 0;
}

button,
input,
optgroup,
select,
textarea {
  font-family: inherit;
  /* 1 */
  font-size: 100%;
  /* 1 */
  line-height: 1.15;
  /* 1 */
  margin: 0;
  /* 2 */
}

/**
 * Show the overflow in IE.
 * 1. Show the overflow in Edge.
 */
button,
input {
  /* 1 */
  overflow: visible;
}

/**
 * Remove the inheritance of text transform in Edge, Firefox, and IE.
 * 1. Remove the inheritance of text transform in Firefox.
 */
button,
select {
  /* 1 */
  text-transform: none;
}

/**
 * Correct the inability to style clickable types in iOS and Safari.
 */
button,
[type=button],
[type=reset],
[type=submit] {
  -webkit-appearance: button;
}

/**
 * Remove the inner border and padding in Firefox.
 */
button::-moz-focus-inner,
[type=button]::-moz-focus-inner,
[type=reset]::-moz-focus-inner,
[type=submit]::-moz-focus-inner {
  border-style: none;
  padding: 0;
}

/**
 * Restore the focus styles unset by the previous rule.
 */
button:-moz-focusring,
[type=button]:-moz-focusring,
[type=reset]:-moz-focusring,
[type=submit]:-moz-focusring {
  outline: 1px dotted ButtonText;
}

/**
 * Correct the padding in Firefox.
 */
fieldset {
  padding: 0.35em 0.75em 0.625em;
}

/**
 * 1. Correct the text wrapping in Edge and IE.
 * 2. Correct the color inheritance from `fieldset` elements in IE.
 * 3. Remove the padding so developers are not caught out when they zero out
 *    `fieldset` elements in all browsers.
 */
legend {
  box-sizing: border-box;
  /* 1 */
  color: inherit;
  /* 2 */
  display: table;
  /* 1 */
  max-width: 100%;
  /* 1 */
  padding: 0;
  /* 3 */
  white-space: normal;
  /* 1 */
}

/**
 * Add the correct vertical alignment in Chrome, Firefox, and Opera.
 */
progress {
  vertical-align: baseline;
}

/**
 * Remove the default vertical scrollbar in IE 10+.
 */
textarea {
  overflow: auto;
}

/**
 * 1. Add the correct box sizing in IE 10.
 * 2. Remove the padding in IE 10.
 */
[type=checkbox],
[type=radio] {
  box-sizing: border-box;
  /* 1 */
  padding: 0;
  /* 2 */
}

/**
 * Correct the cursor style of increment and decrement buttons in Chrome.
 */
[type=number]::-webkit-inner-spin-button,
[type=number]::-webkit-outer-spin-button {
  height: auto;
}

/**
 * 1. Correct the odd appearance in Chrome and Safari.
 * 2. Correct the outline style in Safari.
 */
[type=search] {
  -webkit-appearance: textfield;
  /* 1 */
  outline-offset: -2px;
  /* 2 */
}

/**
 * Remove the inner padding in Chrome and Safari on macOS.
 */
[type=search]::-webkit-search-decoration {
  -webkit-appearance: none;
}

/**
 * 1. Correct the inability to style clickable types in iOS and Safari.
 * 2. Change font properties to `inherit` in Safari.
 */
::-webkit-file-upload-button {
  -webkit-appearance: button;
  /* 1 */
  font: inherit;
  /* 2 */
}

/* Interactive
   ========================================================================== */
/*
 * Add the correct display in Edge, IE 10+, and Firefox.
 */
details {
  display: block;
}

/*
 * Add the correct display in all browsers.
 */
summary {
  display: list-item;
}

/* Misc
   ========================================================================== */
/**
 * Add the correct display in IE 10+.
 */
template {
  display: none;
}

/**
 * Add the correct display in IE 10.
 */
[hidden] {
  display: none;
}

/* Tables
   ========================================================================== */
/**
 * Remove most spacing between table cells.
 */
table {
  border-collapse: collapse;
  border-spacing: 0;
}

td,
th {
  padding: 0;
}

/* List
==============================================================================*/
ol, ul {
  list-style: none;
  padding-left: 0;
}

h1 {
  font-size: 3em;
  font-weight: 600;
}

h2 {
  font-size: 2em;
  font-weight: 600;
}

h3, h4, h5 {
  font-size: 1em;
  font-weight: 1300;
  font-family: "Dancing Script";
}

h6 {
  font-size: 2em;
  font-weight: 1500;
}

main {
  margin: 0;
  padding: 0;
}

body {
  background-color: #faf9fa;
  display: flex;
  flex-direction: column;
  margin: 1em auto;
  min-height: 100vh;
  width: 90%;
}

header {
  background-color: #457ce2;
  margin: 0;
  padding: 1em;
  height: 10v;
  display: flex;
  flex-direction: column;
}
header .logo-titulo {
  display: flex;
  justify-content: space-between;
}
header .logo-titulo .logo {
  width: max-content;
}
header .logo-titulo .logo svg {
  height: 3em;
  width: 3em;
}
header .logo-titulo .logo svg g {
  fill: black;
}
header .logo-titulo .titulo {
  font-size: 0.7em;
  margin: auto 0;
}
header .menu {
  margin: auto 0;
}
header .menu li {
  font-size: 1.1em;
  font-weight: 300;
  display: inline;
  padding: 0.1 13px;
  background-color: #f2f5f7;
}

footer {
  margin-top: auto;
  width: 100%;
}
footer .footer-element {
  width: 100%;
}
footer .footer-element p {
  text-align: center;
}

.desktop-cuatro-columnas {
  display: flex;
  justify-content: space-between;
  width: 100%;
}
.desktop-cuatro-columnas .columna {
  width: 22%;
}

.desktop-tres-columnas {
  display: flex;
  justify-content: space-between;
  width: 100%;
}
.desktop-tres-columnas .columna {
  width: 30%;
}

.desktop-dos-columnas {
  display: flex;
  justify-content: space-between;
  width: 100%;
}
.desktop-dos-columnas .columna {
  width: 48%;
}

.desktop-dos-columnas-aside {
  display: flex;
  justify-content: space-between;
  width: 100%;
}
.desktop-dos-columnas-aside .columna-aside {
  width: 20%;
}
.desktop-dos-columnas-aside .columna-main {
  width: 75%;
}

.desktop-dos-columnas-inline {
  display: flex;
  justify-content: space-between;
  width: 100%;
}
.desktop-dos-columnas-inline .columna {
  width: 48%;
}
.desktop-dos-columnas-inline .columna div {
  display: flex;
  margin-right: 1em;
}

.desktop-una-columna {
  width: 100%;
  margin-top: 1rem;
}
.desktop-una-columna .columna {
  width: 100%;
  margin-top: 1rem;
}

.mobile-five-columns {
  display: flex;
  justify-content: space-between;
  width: 100%;
}
.mobile-five-columns .column {
  width: 18%;
}

.mobile-four-columns {
  display: flex;
  justify-content: space-between;
  width: 100%;
}
.mobile-four-columns .column {
  width: 22%;
}

.mobile-three-columns {
  display: flex;
  justify-content: space-between;
  width: 100%;
}
.mobile-three-columns .column {
  width: 30%;
}

.mobile-two-columns {
  display: flex;
  justify-content: space-between;
  width: 100%;
}
.mobile-two-columns .column {
  width: 48%;
}

.mobile-one-column {
  width: 100%;
  display: block;
}
.mobile-one-column .column {
  width: 100%;
}

.slider {
  width: 100%;
}

.subtitulo {
  background-color: #6db7f3;
  font-family: "Dancing Script";
  margin-top: 0.5em;
  padding: 0.2em 0;
  width: 100%;
  margin-bottom: 1rem;
}
.subtitulo h2 {
  text-align: center;
  font-size: 1.2em;
  margin: 0;
}

.cesta .tabla-cesta {
  width: 100%;
  text-align: center;
  margin: 0;
  border: solid;
}
.cesta .tabla-cesta th {
  background-color: #f8cff0;
  padding: 1rem;
  font-size: 0.6rem;
  font-weight: bold;
}
.cesta .tabla-cesta td {
  color: #ae1e83;
  font-weight: bold;
  font-size: 0.6rem;
  width: 20%;
}
.cesta .tabla-cesta td input {
  width: 10%;
}
.cesta .desktop-dos-columnas-inline .columna-imagen {
  margin-left: 0.5rem;
}
.cesta .desktop-dos-columnas-inline .columna-sumatorio {
  width: 100%;
  margin-right: 1rem;
  margin-top: 3rem;
  font-weight: bold;
  font-size: 0.5rem;
}
.cesta .desktop-dos-columnas-inline .columna-sumatorio .total {
  color: #ae1e83;
}
.cesta .desktop-dos-columnas-inline .columna-sumatorio th {
  text-align: left;
}
.cesta .desktop-dos-columnas-inline .columna-sumatorio td {
  width: 10%;
  text-align: right;
}
.cesta .botones {
  width: 100%;
  margin: 2rem;
  display: flex;
  font-size: 2rem;
}
.cesta .botones button {
  background-color: #6bc9f5;
  height: 3rem;
  width: 80%;
  margin: auto 1rem;
  font-weight: bold;
  font-size: 1rem;
}
.cesta .botones .boton-pagar {
  margin-top: 0.5rem;
}

.checkout .desktop-dos-columnas {
  display: flex;
  flex-direction: column;
  width: 100%;
}
.checkout .desktop-dos-columnas .columna {
  width: 100%;
}
.checkout .desktop-dos-columnas .columna .form-contact {
  color: #0f0f0f;
  background-image: none;
  padding: none;
  font-weight: bold;
  font-size: 1.5rem;
}
.checkout .desktop-dos-columnas .columna .form-contact .contact-form-input input {
  margin-bottom: 0;
  width: 95%;
}
.checkout .desktop-dos-columnas .columna .subtitulo-resumen {
  background-color: #f7b1f1;
  margin-top: 1.5rem;
  text-align: center;
  margin-left: 0;
  margin-bottom: 1rem;
}
.checkout .desktop-dos-columnas .columna .subtitulo-resumen h8 {
  font-family: "Dancing Script";
  font-size: 2rem;
}
.checkout .desktop-dos-columnas .columna .resumen-de-producto {
  font-size: 0.6rem;
}
.checkout .desktop-dos-columnas .columna .resumen-de-producto .columna {
  width: 95%;
  text-align: center;
}
.checkout .desktop-dos-columnas .columna .resumen-de-producto .columna .tabla-cesta {
  margin-bottom: 1rem;
}
.checkout .desktop-dos-columnas .columna .resumen-de-producto .columna .tabla-cesta th {
  padding: 0.1rem;
  font-size: 0.6rem;
}
.checkout .desktop-dos-columnas .columna .resumen-de-producto .columna .tabla-cesta td {
  font-size: 1rem;
}
.checkout .desktop-dos-columnas .columna .resumen-de-producto .columna .tabla-cesta input {
  width: 10%;
}
.checkout .desktop-dos-columnas .columna .columna-sumatorio {
  margin-left: 0;
  font-weight: bold;
  margin-bottom: 3rem;
}
.checkout .desktop-dos-columnas .columna .columna-sumatorio .tabla-sumatorio {
  width: 90%;
  text-align: end;
}
.checkout .desktop-dos-columnas .columna .forma-de-pago {
  background-color: #f0d1e9;
  margin-left: 0;
  font-size: 1.1rem;
  margin-bottom: 1rem;
}
.checkout .desktop-dos-columnas .columna .forma-de-pago h7 {
  text-decoration: underline #f58fd3 3px;
  font-weight: bold;
  margin: 1rem;
}
.checkout .desktop-dos-columnas .columna .forma-de-pago .tabla-forma-de-pago th {
  width: 30%;
  padding: 0.1rem;
  margin: 0;
}
.checkout .desktop-dos-columnas .columna .forma-de-pago .tabla-forma-de-pago th img {
  width: 3rem;
  height: 2rem;
  margin: auto 3rem;
}
.checkout .desktop-dos-columnas .columna .forma-de-pago button {
  margin: 1rem 50%;
}

.contacto .desktop-dos-columnas {
  display: flex;
  flex-direction: column;
}
.contacto .desktop-dos-columnas .columna {
  width: 100%;
}
.contacto .desktop-dos-columnas .columna .contacto-informacion .contacto-informacion-opcion {
  display: flex;
  flex-direction: inline;
  margin: auto;
  padding: 1rem 0;
}
.contacto .desktop-dos-columnas .columna .contacto-informacion .contacto-informacion-opcion .contacto-informacion-opcion-imagen svg {
  width: 2em;
  height: 2em;
}
.contacto .desktop-dos-columnas .columna .contacto-informacion .contacto-informacion-opcion .contacto-informacion-opcion-imagen svg path {
  fill: #ae1e83;
}
.contacto .desktop-dos-columnas .columna .contacto-informacion .contacto-informacion-opcion .contacto-informacion-opcion-text {
  margin: auto 1rem;
}
.contacto .desktop-dos-columnas .columna .contacto-informacion .contacto-informacion-opcion .contacto-informacion-opcion-text span {
  font-size: 1.3rem;
  font-weight: bold;
}
.contacto .desktop-dos-columnas .columna .contacto-informacion .google iframe {
  width: 100%;
  margin: 1em auto;
}
.contacto .desktop-dos-columnas .columna .form-contact {
  color: #0f0f0f;
  background-image: url("/images/fondo gaticos.jpg");
  padding: 0.8rem;
  font-weight: bold;
  font-size: 1rem;
  margin: 1rem auto;
  border-style: solid;
}
.contacto .desktop-dos-columnas .columna .form-contact .contact-form-label {
  margin-bottom: 0.5rem;
}
.contacto .desktop-dos-columnas .columna .form-contact .contact-form-input input {
  margin-bottom: 2rem;
  width: 100%;
}
.contacto .desktop-dos-columnas .columna .form-contact .contact-form-input textarea {
  width: 100%;
  height: 5rem;
}
.contacto .desktop-dos-columnas .columna .form-contact .contact-store-button {
  width: 30%;
  background-color: #6db7f3;
  color: #0e0d0d;
  padding: 5px;
  margin: 0 35%;
  border-radius: 4%;
  font-weight: bold;
  font-size: 1rem;
}

.home .subtitulo {
  margin-bottom: 1rem;
}
.home .subtitulo h2 {
  font-size: 1.2em;
  text-shadow: none;
  margin: 0;
}
.home .animales {
  display: flex;
  flex-direction: column;
}
.home .animales .animal {
  width: 100%;
  display: flex;
  justify-content: space-between;
  margin-bottom: 0.2em;
}
.home .animales .animal .animal-imagen {
  width: 30%;
}
.home .animales .animal .animal-titulo {
  width: 20%;
  font-size: 0.5em;
  margin: 0.5em 0;
}
.home .animales .animal .animal-titulo h3 {
  color: #ae1e83;
  font-size: 1.5em;
  text-align: center;
}
.home .animales .animal .animal-descripcion {
  width: 50%;
  font-size: 0.8em;
  background-color: #72a3db;
}
.home .contact {
  display: flex;
  justify-content: space-between;
  margin: 1em 0;
  padding: 1em 0;
  border-top: 1px solid #241a1a;
  border-bottom: 1px solid #241a1a;
}
.home .contact .contact-form {
  width: 50%;
  font-size: 0.9em;
}
.home .contact .contact-form .contact-suscription-form {
  background-color: #ec9f5f;
}
.home .contact .contact-form .contact-suscription-form .contact-form-input {
  width: 100%;
}
.home .contact .contact-form .contact-suscription-form .contact-form-input input {
  width: 90%;
}
.home .contact .contact-image {
  width: 40%;
  margin-top: 10%;
}
.home .contact .contact-image img {
  border-radius: 50%;
  box-shadow: 5px 5px 15px 5px #241a1a;
}

.ficha {
  display: flex;
  flex-direction: column;
  width: 100%;
  margin: 0;
}
.ficha .desktop-dos-columnas {
  display: flex;
  flex-direction: column;
  width: 100%;
  margin-top: 1rem;
}
.ficha .desktop-dos-columnas .columna {
  width: 100%;
}
.ficha .desktop-dos-columnas .columna .foto-ficha {
  margin: 0;
}
.ficha .desktop-dos-columnas .columna .subfotos-ficha {
  width: 100%;
  display: flex;
  justify-content: space-between;
  margin: 0;
}
.ficha .desktop-dos-columnas .columna .subfotos-ficha .subfoto-imagen {
  width: 18%;
  margin: 1%;
}
.ficha .desktop-dos-columnas .columna .coste {
  width: 100%;
  display: flex;
  justify-content: space-between;
  margin-bottom: 3rem;
}
.ficha .desktop-dos-columnas .columna .coste h3 {
  font-size: 2rem;
  color: #ae1e83;
  margin: auto;
  width: 30%;
}
.ficha .desktop-dos-columnas .columna .coste span {
  background-color: #f0b7de;
  font-size: 1rem;
  width: 65%;
}
.ficha .desktop-dos-columnas .columna .descripcion {
  border: solid;
  border-color: #ae1e83;
  padding: 1rem;
  font-weight: bold;
  font-size: 1.1rem;
  margin-bottom: 0;
}
.ficha .desktop-dos-columnas .columna .descripcion h7 {
  font-size: 1.3rem;
  text-decoration: underline wavy #f58fd3 3px;
}
.ficha .desktop-dos-columnas .columna .descripcion p {
  margin: 1rem 0;
  text-align: justify;
}
.ficha .desktop-dos-columnas .columna .descripcion .video-descripcion {
  margin: 0;
}
.ficha .desktop-dos-columnas .columna .descripcion .video-descripcion iframe {
  width: 18rem;
  height: 10rem;
}
.ficha .desktop-dos-columnas .columna .cantidad {
  width: 100%;
  display: flex;
  flex-direction: column;
}
.ficha .desktop-dos-columnas .columna .cantidad span {
  font-size: 0.8rem;
  font-weight: bold;
  margin: 0;
  text-align: justify;
}
.ficha .desktop-dos-columnas .columna .cantidad .cantidad-acogida {
  display: flex;
  flex-direction: inline;
  margin: 1rem;
}
.ficha .desktop-dos-columnas .columna .cantidad .cantidad-acogida .titulo-cantidad-acogida {
  width: 70%;
  margin-top: 3%;
}
.ficha .desktop-dos-columnas .columna .cantidad .cantidad-acogida .botones-cantidad {
  margin: 0;
  width: 100%;
}
.ficha .desktop-dos-columnas .columna .cantidad .cantidad-acogida .botones-cantidad input {
  width: 15%;
  margin-bottom: 2rem;
}
.ficha .desktop-dos-columnas .columna .botones-adopcion-acogida {
  display: flex;
  justify-content: space-between;
  margin-bottom: 3rem;
}
.ficha .desktop-dos-columnas .columna .botones-adopcion-acogida button {
  margin-left: 0.1rem;
  height: 3rem;
  width: 10rem;
  font-weight: bold;
}
.ficha .desktop-dos-columnas .columna .botones-adopcion-acogida .boton-acogida button {
  background-color: #f8b9f0;
}
.ficha .desktop-dos-columnas .columna .botones-adopcion-acogida .boton-adopcion button {
  background-color: #6bc9f5;
}

.galeria .desktop-dos-columnas-aside {
  width: 100%;
  display: flex;
  flex-direction: column;
}
.galeria .desktop-dos-columnas-aside .columna-categoria {
  width: 100%;
}
.galeria .desktop-dos-columnas-aside .columna-categoria li {
  font-size: 1.3rem;
  text-align: center;
  border: solid;
  border-radius: 3%;
  color: #ae1e83;
}
.galeria .desktop-dos-columnas-aside .columna-main {
  width: 100%;
}
.galeria .desktop-dos-columnas-aside .columna-main .columna-main-galeria {
  width: 100%;
  display: flex;
  flex-direction: column;
}
.galeria .desktop-dos-columnas-aside .columna-main .columna-main-galeria .selector {
  background-color: #6bc9f5;
  padding: 0.5rem;
  font-weight: bold;
  font-size: 1.2rem;
  display: flex;
  justify-content: space-between;
  margin-bottom: 2rem;
  text-align: center;
}
.galeria .desktop-dos-columnas-aside .columna-main .columna-main-galeria .selector span {
  font-size: 1rem;
}
.galeria .desktop-dos-columnas-aside .columna-main .columna-main-galeria .selector .boton-selector {
  background-color: #c5e9f7;
  padding-top: 13%;
  font-size: 1rem;
}
.galeria .desktop-dos-columnas-aside .columna-main .columna-main-galeria .galeria-animales {
  width: 100%;
  display: flex;
  flex-direction: column;
  font-size: 0.7rem;
  margin-bottom: 1rem;
}
.galeria .desktop-dos-columnas-aside .columna-main .columna-main-galeria .galeria-animales .galeria-animal .desktop-tres-columnas .animal {
  display: flex;
  flex-direction: column;
  margin-bottom: 2rem;
  text-align: center;
  width: 30%;
}
.galeria .desktop-dos-columnas-aside .columna-main .columna-main-galeria .galeria-animales .galeria-animal .desktop-tres-columnas .animal img {
  width: 90%;
}
.galeria .desktop-dos-columnas-aside .columna-main .columna-main-galeria .galeria-animales .galeria-animal .desktop-tres-columnas .animal h3 {
  font-size: 1rem;
  color: #ae1e83;
}
.galeria .desktop-dos-columnas-aside .columna-main .columna-main-galeria .galeria-animales .galeria-animal .desktop-tres-columnas .animal p {
  font-weight: bold;
}

/*# sourceMappingURL=mobile-app.cs.map */
