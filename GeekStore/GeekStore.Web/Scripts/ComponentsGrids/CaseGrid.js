$(document).ready(function () {
    debugger;
    $('#table').jtable({
        title: 'All Cases',
        actions: {
            listAction: '/Administration/Cases/Index',
            createAction: '/Cases/Create',
            updateAction: '/Cases/Update',
            deleteAction: '/Cases/Delete'
        },
        fields: {
            Id: {
                key: true,
                list: false
            },
            Manufacturer: {
                title: 'Manufacturer',
                width: '15%'
            },
            Model: {
                title: 'Model',
                width: '45%'
            },
            FormFactor: {
                title: 'Form Factor',
                width: '30%'
            },
            Price: {
                title: 'Price',
                width: ''
            },
            Quantity: {
                title: 'Quantity',
                width: '',
                create: false,
                edit: false
            }
        }
    });
});