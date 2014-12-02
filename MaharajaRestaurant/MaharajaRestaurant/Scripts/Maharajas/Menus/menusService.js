maharajasApp.factory('menusService', function () {
    var getall = function () {
        var temp = [
            [
                {
                    id: 0,
                    imgurl: '/Images/Boxes/300x300-Box.png',
                    title: 'Integer et pretium velit.',
                    description: 'Cras massa diam, cursus sit amet sagittis a, rhoncus ut nunc. Quisque sodales eros eget erat scelerisque sodales.',
                    price: '$2.50 (3pcs)'
                },
                {
                    id: 1,
                    imgurl: '/Images/Boxes/300x300-Box.png',
                    title: 'Sed ante nulla, molestie eu ipsum id.',
                    description: 'Etiam ac tempor tortor, id viverra massa. Vestibulum eros nunc, rutrum sed lacus et, ultrices pulvinar turpis.',
                    price: '$2.50 (3pcs)'
                },
                {
                    id: 2,
                    imgurl: '/Images/Boxes/300x300-Box.png',
                    title: 'Quisque a arcu tortor.',
                    description: ' Etiam sed ultricies metus, at condimentum neque. Nulla ac gravida lacus.',
                    price: '$2.50 (3pcs)'
                },
                {
                    id: 3,
                    imgurl: '/Images/Boxes/300x300-Box.png',
                    title: 'Fusce posuere tristique mi et.',
                    description: 'Sed semper nisl sit amet quam interdum mollis ac ac dui.',
                    price: '$2.50 (3pcs)'
                }
            ],
            [
                {
                    id: 4,
                    imgurl: '/Images/Boxes/300x300-Box.png',
                    title: 'Integer et pretium velit.',
                    description: 'Cras massa diam, cursus sit amet sagittis a, rhoncus ut nunc. Quisque sodales eros eget erat scelerisque sodales.',
                    price: '$2.50 (3pcs)'
                },
                {
                    id: 5,
                    imgurl: '/Images/Boxes/300x300-Box.png',
                    title: 'Sed ante nulla, molestie eu ipsum id.',
                    description: 'Etiam ac tempor tortor, id viverra massa. Vestibulum eros nunc, rutrum sed lacus et, ultrices pulvinar turpis.',
                    price: '$2.50 (3pcs)'
                },
                {
                    id: 6,
                    imgurl: '/Images/Boxes/300x300-Box.png',
                    title: 'Quisque a arcu tortor.',
                    description: ' Etiam sed ultricies metus, at condimentum neque. Nulla ac gravida lacus.',
                    price: '$2.50 (3pcs)'
                },
                {
                    id: 7,
                    imgurl: '/Images/Boxes/300x300-Box.png',
                    title: 'Fusce posuere tristique mi et.',
                    description: 'Sed semper nisl sit amet quam interdum mollis ac ac dui.',
                    price: '$2.50 (3pcs)'
                }
            ]
        ]

        return temp;
    };
    return {
        menuslist: getall()
    }
});