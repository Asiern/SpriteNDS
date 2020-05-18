Sprite converter for NDS
===

Convert sprites to NDS matrix


![alt text](https://raw.githubusercontent.com/Asiern/SpriteNDS/master/SpriteNDS.png)

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

#### Known issues

Wide range collor palletes might cause issues due to color repetition. This happens when converting the color from RGB 24 bit to RGB 15 bit

For this reason, it is recommended to use images composed by as few colors as posible.
To achieve this, it is convenient to use an image editor as Adobe Photoshop, Gimp...

---

#### Material Skin

Using [MaterialSkin](https://github.com/IgnaceMaes/MaterialSkin) by Ignace Maes


