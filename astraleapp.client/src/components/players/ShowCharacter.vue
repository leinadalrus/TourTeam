<script lang="ts">
import CharacterSheet from './CharacterSheet.vue'

function characterSheets(id: number): Array<typeof CharacterSheet> {
  let characters = CharacterSheet[id]
  return characters
}

export default {
  data(n: number) {
    return {
      articles: characterSheets(n)
    }
  }
}
</script>

<template>
  <article>
    <img src="" alt="" srcset="" />
    <ul v-for="article in articles" :key="article.id">
      <li v-show="article">
        {{ article }}
      </li>
    </ul>
  </article>
</template>

<style scoped module="styles" lang="scss"></style>