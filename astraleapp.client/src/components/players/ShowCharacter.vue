<script setup lang="ts">
import { ref, watch } from "vue"
import CharacterSheet from './CharacterSheet.vue'

const characterArticles = ref(0)

function characterSheets(id: number): Array<typeof CharacterSheet> {
  let characters = CharacterSheet[id]
  return characters
}

watch(characterArticles, (article) => {
  console.log(article)
})
</script>

<template>
  <article>
    <img src="" alt="" srcset="" />
    <ul v-for="article in characterArticles">
      <li v-show="article">
        {{ article }}
      </li>
    </ul>
  </article>
</template>

<style scoped module="styles" lang="scss"></style>