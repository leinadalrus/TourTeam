<script setup lang="ts">
import { ref } from "vue"
// `import type` creates a file-module equivalent to Vue's `<script setup>`
import { defineStore } from "pinia"

const useCharacterSheetStore = defineStore("player", () => {})

const id = ref(0)
const name = ref("")
const image = ref("")

function getID(characterID: number): number {
  id.value = characterID
  return id.value
}
function getName(characterName: string): string {
  name.value = characterName
  return name.value
}
function getImage(imageFilepath: string): string {
  image.value = imageFilepath
  return image.value
}
</script>

<template>
  <article v-show="getID(1)">
    <img
      :src="getImage('public/user/avatars/**')"
      alt=""
    />
    <p>{{ getName("John Doe") }}</p>
  </article>
</template>

<style scoped module="styles" lang="scss"></style>
