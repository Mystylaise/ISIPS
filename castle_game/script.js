var game = new Phaser.Game(800, 600, Phaser.AUTO, 'canva', { preload: preload, create: create, update: update });

function preload() {
game.load.image('background', 'assets/bg.png');
game.load.image('Player', 'assets/star.png');
} //end function preload

var Player;
var cursors;
var Saut;

function create() {

	game.physics.startSystem(Phaser.Physics.ARCADE);

	// Détermine les dimentions du background
	game.world.setBounds(0, 0, 1200, 600);

	// Crée et détermine les coordinées du personnage @start
	Player=game.add.sprite(50, 528, 'Player');

	game.physics.arcade.gravity.y = 350;

	game.physics.enable(Player, Phaser.Physics.ARCADE);

    Player.body.bounce.y = 0.1; //Ajoute un rebond au personnage après 1 saut
    Player.body.collideWorldBounds = true; // Ajoute la collision avec les bords de l'écran 
    Player.body.setSize(24, 22, 0, 0); // // largeur/longueur/offset x / offest y

    // Camera suit le joueur lors du dépassement du background
    game.camera.follow(Player);

    // Reconnaisance des touches
    cursors = game.input.keyboard.createCursorKeys();
    Saut = game.input.keyboard.addKey(Phaser.Keyboard.SPACEBAR);
   	

} //end function create

function update() {

	// Définis la résistance sur l'axe X et Y
	Player.body.velocity.x = 0;

    if (cursors.left.isDown)
    {
        Player.body.velocity.x = -140;
    }
    else if (cursors.right.isDown)
    {
        Player.body.velocity.x = 140;
    }
     if (Saut.isDown && Player.body.onFloor() )
    {
        Player.body.velocity.y = -150;
    }
} //end function update

function render() {

} //end function render