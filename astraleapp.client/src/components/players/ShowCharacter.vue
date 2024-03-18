<script setup lang="ts">
import { computed, defineComponent, defineEmits, ref, watch } from "vue"
import CharacterSheet from "./CharacterSheet.vue"
import CustomAvatar from "./CustomAvatar.vue"

const characterArticles = ref(0)

const emit = defineEmits<{ selected: [] }>()

function characterSheets(id: number): Array<typeof CharacterSheet> {
  let characters = CharacterSheet[id]
  emit(characters)
  return characters
}

watch(characterArticles, (tail) => {
  characterSheets(tail)
})
</script>

<template>
  <section>
    <CustomAvatar />
  </section>
  <article>
    <ul v-for="article in characterArticles">
      <li v-show="article">
        {{ article }}
      </li>
    </ul>
  </article>
</template>

<style scoped module="styles" lang="scss"></style>