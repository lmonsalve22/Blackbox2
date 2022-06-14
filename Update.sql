update contenido_insertado set comentario = 'https://forms.monday.com/forms/embed/6893a09668c06dae729a4ec6422b5ed3?r=use1' where id >= 11 and id <= 90
update contenido_insertado set comentario = 'https://forms.monday.com/forms/embed/fa67d7090f2b5daf506ac487b8732f6d?r=use1' where id >= 91 and id <= 170
update contenido_insertado set comentario = 'https://forms.monday.com/forms/embed/621f5c84cc5fa6e7c31b934469b46af5?r=use1' where id >= 171 and id <= 330
update contenido_insertado set comentario = 'https://forms.monday.com/forms/embed/9db49d3ea8e0e9d7e54c471ac264c0b4?r=use1' where id >= 331 and id <= 410
update contenido_insertado set comentario = 'https://forms.monday.com/forms/embed/9db49d3ea8e0e9d7e54c471ac264c0b4?r=use1' where id >= 331 and id <= 410
update contenido_insertado set comentario = 'https://forms.monday.com/forms/embed/ed2122cca0b58080dd2c6c9edfb6a8ff?r=use1' where id >= 411 and id <= 490
update contenido_insertado set comentario = 'https://forms.monday.com/forms/embed/ed2122cca0b58080dd2c6c9edfb6a8ff?r=use1' where id >= 491 and id <= 525
update contenido_insertado set comentario = 'https://forms.monday.com/forms/embed/7d7244e892f6040312308624f063a332?r=use1' where id >= 526 and id <= 605
update contenido_insertado set comentario = 'https://forms.monday.com/forms/embed/ad1c7633a5958cae9e24ca66bfb7b443?r=use1' where id >= 606 and id <= 685
update contenido_insertado set comentario = 'https://forms.monday.com/forms/embed/451453dd84650e6bb0afafe6de1355b6?r=use1' where id >= 686 and id <= 765
update contenido_insertado set comentario = 'https://forms.monday.com/forms/embed/cf1f18644c78cd0ee8123941f78e05a0?r=use1' where id >= 766 and id <= 845
update contenido_insertado set comentario = 'https://forms.monday.com/forms/embed/f707759b943c6f6e107665bef79159fa?r=use1' where id >= 846 and id <= 925

update contenido_insertado set comentario = 'https://forms.monday.com/forms/embed/1b0cdae45f7d2f680d5d8c0b508aac68?r=use1' 
where comentario not like 'https%' or comentario is null
