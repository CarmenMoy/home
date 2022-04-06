import '../../node_modules/@ckeditor/ckeditor5-build-classic/build/ckeditor.js';

export let renderCkeditor = () => {

    ClassicEditor
        .create( document.querySelectorAll('.editor'))

        .then( editor => {
            window.editor = editor;
        } )
        
        .catch( error => {
            console.error( 'There was a problem initializing the editor.', error );
        } );
};