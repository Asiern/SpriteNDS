Sprite converter for NDS
===

Convert sprites to NDS matrix


![alt text](https://raw.githubusercontent.com/Asiern/SpriteNDS/master/SpriteNDS.png)

---

#### Use Guide

As shown in the image, this tools has 3 buttons "IMPORT", "GENERATE" and "ABOUT".

- By clicking on the "IMPORT" button you can import an [image](https://github.com/Asiern/SpriteNDS#sprite-converter-for-nds) of the formats shown at [supported files](https://github.com/Asiern/SpriteNDS#supported-files). After importing an image a preview will load on the top right corner.

- To generate the Sprite Matrix and the Color Palette, press GENERATE and both Sprite Matrix and Collor Palette will load.

- To finish up, copy both Sprite Matrix and Collor Palette contents into 'source\sprites.c'

---

#### Supported files

| File extension | Support | 16x16 | 32x32 |
|----------------|---------|-------|-------|
| .jpg           | Yes     | Yes   | Yes   |
| .png           | Yes     | Yes   | Yes   |
| .bmp           | Yes     | Yes   | Yes   |
| .gif           |   ?     |   ?   |   ?   |
| .mpo           | No      |   -   |   -   |
| .jpf           | No      |   -   |   -   |
| .iff           | No      |   -   |   -   |
| .dcm           | No      |   -   |   -   |
| .psd           | No      |   -   |   -   |
| .jps           | No      |   -   |   -   |


---

#### Exceptions

- ImageNotSelected
- FileNotSupported

---

#### Known issues

Wide range collor palettes might cause issues due to color repetition. This happens when converting the color from RGB 24 bit to RGB 15 bit

For this reason, it is recommended to use images composed by as few colors as posible.
To achieve this, it is convenient to use an image editor as Adobe Photoshop, Gimp...

---

#### Material Skin

Using [MaterialSkin](https://github.com/IgnaceMaes/MaterialSkin) by Ignace Maes


